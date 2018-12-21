using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVTr
{
    public partial class FormNV : DevExpress.XtraEditors.XtraForm
    {
        DataTableLog ur;

        public FormNV()
        {
            InitializeComponent();
            ur = new DataTableLog(dataSetDS.NhanVien);
        }

        bool isSave = false;
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
             isSave = true;
            if (dataSetDS.NhanVien.HasErrors)
            {
                MessageBox.Show("Lỗi dữ liệu đầu vào!");

            }
            else
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetDS);
                MessageBox.Show("saved!");
            }
            isSave = false;
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            if (DBmanager.userDangNhap.Role == "USER")
            {
                btnNewLogin.Visible = false;

            }else if(DBmanager.userDangNhap.Role == "CONGTY")
            {
                btnAdd.Visible = false;
                btnSave.Visible = false;
                btnRemove.Visible = false;
                btnUndo.Visible = false;
                btnRedo.Visible = false;
                gridView1.OptionsBehavior.ReadOnly = true;
            }

            // TODO: This line of code loads data into the 'dataSetDS.NhanVien' table. You can move, or remove it, as needed.
            if(tableAdapterManager.ChiNhanhTableAdapter==null)
                tableAdapterManager.ChiNhanhTableAdapter = new DataSetDSTableAdapters.ChiNhanhTableAdapter();
            tableAdapterManager.ChiNhanhTableAdapter.Connection.Close();
            tableAdapterManager.ChiNhanhTableAdapter.Connection = DBmanager.connection; ;
            tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);

            nhanVienTableAdapter.Connection.Close();
            nhanVienTableAdapter.Connection = DBmanager.connection;
            nhanVienTableAdapter.Fill(this.dataSetDS.NhanVien);

            
            this.nhanVienBindingSource.Filter = "TrangThaiXoa = 0 or TrangThaiXoa is null";


            dataSetDS.NhanVien.ColumnChanged += onColumnChanged;
            //dataSetDS.NhanVien.RowChanged += onRowChanged;

            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;
           
        }

        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            //this.dataSetDS.NhanVien.Clear();
            dataSetDS.EnforceConstraints = false;
            tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);
            nhanVienTableAdapter.Fill(this.dataSetDS.NhanVien);
            dataSetDS.EnforceConstraints = true;
        }


        //void onRowChanged(object sender, DataRowChangeEventArgs e)
        //{
        //    //if (e.Row.RowState==DataRowState.Added)
        //    //{
        //    //    for (int i = 0; i < e.Row.ItemArray.Length; i++)
        //    //    {
        //    //        if (e.Row[i].ToString().Trim() == "")
        //    //        {
        //    //            e.Row.SetColumnError(i, "Không được bỏ trống!");
        //    //        }
        //    //    }
        //    //}
        //}
        //void onRowChanged(object sender, DataRowChangeEventArgs e)
        //{
        //    //if (e.Row.RowState != DataRowState.Modified)
        //    //{
        //    MessageBox.Show(e.Row.Table.IsInitialized.ToString());
        //    if (e.Row.Table. == true)
        //        return;
        //    string sql = "SP_CHECKMANV";
        //    SqlCommand commander = new SqlCommand(sql, DBmanager.connection);
        //    commander.CommandType = CommandType.StoredProcedure;
        //    commander.Parameters.AddWithValue("@manv", ((DataRowView)nhanVienBindingSource.Current).Row["MANV"]);
        //    SqlParameter retVal = new SqlParameter("@return", SqlDbType.Int);
        //    retVal.Direction = ParameterDirection.Output;
        //    retVal.Value = 10;
        //    commander.Parameters.Add(retVal);
        //    SqlDataReader reader = commander.ExecuteReader();
        //    reader.Read();
        //    reader.Close();

        //    int returnValue = Convert.ToInt32(retVal.Value);
        //    if (returnValue == 1)
        //    {
        //        e.Row.SetColumnError("MANV", "Mã nhân viên đã tồn tại!");
        //    }
        //    else
        //    {
        //        e.Row.ClearErrors();
        //    }

        //    if (e.Row["LUONG"].GetType() == typeof(DBNull))
        //    {
        //        e.Row.SetColumnError("LUONG", "Lương phải là một số! ");
        //        return;
        //    }
        //    if (Convert.ToInt32(e.Row["LUONG"]) < 4000000)
        //    {
        //        e.Row.SetColumnError("LUONG", "Luong phải lớn hơn hoặc bằng 4000000! ");
        //    }
        //    else
        //    {
        //        e.Row.ClearErrors();
        //    }

        //    //}
        //}
        void onColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (isSave)
                return;
            if (e.Row.RowState != DataRowState.Modified)
            {
                if (e.Column.ColumnName == "MANV")
                {
                    string sql = "SP_CHECKMANV";
                    SqlCommand commander = new SqlCommand(sql, DBmanager.connection);
                    commander.CommandType = CommandType.StoredProcedure;
                    commander.Parameters.AddWithValue("@manv", ((DataRowView)nhanVienBindingSource.Current).Row["MANV"]);
                    SqlParameter retVal = new SqlParameter("@return", SqlDbType.Int);
                    retVal.Direction = ParameterDirection.Output;
                    retVal.Value = 10;
                    commander.Parameters.Add(retVal);
                    SqlDataReader reader = commander.ExecuteReader();
                    reader.Read();
                    reader.Close();

                    int returnValue = Convert.ToInt32(retVal.Value);
                    if (returnValue == 1)
                    {
                        e.Row.SetColumnError(e.Column.ColumnName, "Mã nhân viên đã tồn tại!");
                    }
                    else
                    {
                        e.Row.ClearErrors();
                    }
                }
                else if (e.Column.ColumnName == "LUONG")
                {
                    if (e.Row[e.Column.ColumnName].GetType() == typeof(DBNull))
                    {
                        e.Row.SetColumnError(e.Column.ColumnName, "Lương phải là một số! ");
                        return;
                    }
                    if (Convert.ToInt32(e.Row[e.Column.ColumnName]) < 4000000)
                    {
                        e.Row.SetColumnError(e.Column.ColumnName, "Luong phải lớn hơn hoặc bằng 4000000! ");
                    }
                    else
                    {
                        e.Row.ClearErrors();
                    }
                }
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            this.dataSetDS.NhanVien.Clear();
            this.tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);
            this.nhanVienTableAdapter.Fill(this.dataSetDS.NhanVien);
        }

           

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (((DataRowView)nhanVienBindingSource.Current).Row.RowState==DataRowState.Added|| ((DataRowView)nhanVienBindingSource.Current).IsNew)
            {
                ((DataRowView)nhanVienBindingSource.Current).Delete();
            }else
            {
                ((DataRowView)nhanVienBindingSource.Current)["TrangThaiXoa"] = 1;
                nhanVienBindingSource.MovePrevious();
            }
           
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.AddNew();
            nhanVienBindingSource.MoveLast();
            ((DataRowView)nhanVienBindingSource.Current).Row["MACN"] = ((DataRowView)DBmanager.bindingMACN.Current)["MACN"].ToString();
            ((DataRowView)nhanVienBindingSource.Current).Row["TrangThaiXoa"] = 0;
 //           nhanVienBindingSource.EndEdit();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ur.Undo();
            nhanVienBindingSource.MovePrevious();
            nhanVienBindingSource.MoveNext();
           
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            ur.Redo();
            nhanVienBindingSource.MovePrevious();
            nhanVienBindingSource.MoveNext();
            
        }

        private void btnLoginSetting_Click(object sender, EventArgs e)
        {
            LoginSettingForm lgf = new LoginSettingForm(/*((DataRowView)nhanVienBindingSource.Current).Row["MANV"].ToString()*/DBmanager.userDangNhap.Id);
            lgf.Show();
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {
            LoginSettingForm lgf = new LoginSettingForm(((DataRowView)nhanVienBindingSource.Current).Row["MANV"].ToString());
            lgf.Show();
        }
    }




}