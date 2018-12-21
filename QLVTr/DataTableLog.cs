using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLVTr
{
    class DataTableLog
    {
        public List<LogRecord> Log { get; set; }
        public DataTable Table { get; set; }
        public int Index { get; set; }
        public bool CanRedo { get; set; }
        public bool IsUndoOrRedo { get; set; }
        public DataTableLog( DataTable dt)
        {
            Index = -1;
            IsUndoOrRedo = false;
            Log = new List<LogRecord>();
            this.Table = dt;
            CanRedo = false;
            Table.TableNewRow += OnTableNewRow;
            Table.RowChanged += OnRowChanged;
            Table.ColumnChanging += OnColumnChanging;
            Table.ColumnChanged += OnColumnChanged;
            Table.RowDeleting += OnRowDeleting;
        }

        //them mot row moi
        bool isNew=false;
        protected void OnTableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            isNew = true;
        }
        //mot row moi that su dduocwj them vao data table
        protected void OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (isNew && e.Row.RowState == DataRowState.Added&& !IsUndoOrRedo)
            {
                isNew = false;
      //          MessageBox.Show("row new: " + e.Row[0]);
                if (CanRedo)
                {
                    CanRedo = false;
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                }
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.ADD, e.Row);
                Log.Add(lrc);
                Index++;

            }
        }

        void OnColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Row.RowState == DataRowState.Detached)
            {
                return;
            }
            if (!IsUndoOrRedo)
            {
          //      MessageBox.Show("column changed: " + e.Row[e.Column]);
                if (CanRedo)
                {
                    CanRedo = false;
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                }
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.CHANGED, e.Row);
                Log.Add(lrc);
                Index++;
            }
           
        }
        void OnColumnChanging(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Row.RowState == DataRowState.Detached)
            {
                return;
            }
            if (!IsUndoOrRedo)
            {
           //     MessageBox.Show("column changing: " + e.Row[e.Column]);
                if (CanRedo)
                {
                    CanRedo = false;
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                }
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.CHANGING, e.Row);
                Log.Add(lrc);
                Index++;
            }
        }

        protected void OnRowDeleting(object sender,DataRowChangeEventArgs e)
        {
            if (!IsUndoOrRedo)
            {
                if (CanRedo)
                {
                    CanRedo = false;
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                }
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.DELETE, e.Row);
                Log.Add(lrc);
                Index++;           
            }
        }
        public void Undo()
        {
            IsUndoOrRedo = true;
            if (Index >= 0)
            {
                LogRecord rc = Log[Index];
                if (rc.Status == DataRowStatus.ADD)
                {
                    Table.Rows.Remove(rc.Row);
                    Index--;
                }
                else if (rc.Status == DataRowStatus.CHANGING)
                {
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                    Index--;
                }
                else if (rc.Status == DataRowStatus.CHANGED)
                {
                    Index--;
                    Undo();
                }
                else if (rc.Status == DataRowStatus.DELETE)
                {
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                    Table.Rows.Add(rc.Row);
                    Index--;
                }
                CanRedo = true;
            }

            IsUndoOrRedo = false;
        }
        public void Redo()
        {
            IsUndoOrRedo = true;
            
            if (Index < Log.Count-1)
            {
                Index++;
                LogRecord rc = Log[Index];
                if (rc.Status == DataRowStatus.ADD)
                {
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                    Table.Rows.Add(rc.Row);
                   
                }else if(rc.Status == DataRowStatus.CHANGING)
                {
                    Redo();
                }else if(rc.Status == DataRowStatus.CHANGED)
                {
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                }else if(rc.Status == DataRowStatus.DELETE)
                {
                    Table.Rows.Remove(rc.Row);
                }
            }
           
            IsUndoOrRedo = false;
        }

    }
    enum DataRowStatus
    {
        ADD, DELETE, CHANGING,CHANGED
    }
    class LogRecord
    {
        public Object[] RowItems { get; set; }
        public DataRowStatus Status { get; set; }
        public DataRow Row { get; set; }
        public LogRecord()
        {
        }
        public LogRecord(Object[] ritem, DataRowStatus s, DataRow r)
        {
            RowItems = ritem;
            Status = s;
            Row = r; 
        }
    }
}
