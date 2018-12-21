using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Threading;
using System.Transactions;

namespace QLVTr
{
    public partial class FormVT : DevExpress.XtraEditors.XtraForm
    {
        public FormVT()
        {
            InitializeComponent();
            if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                this.btnAddVT.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnUndo.Visible = false;
                this.btnRedo.Visible = false;
                this.gridView1.OptionsBehavior.ReadOnly = true;
            }
        }
        DataTableLog log;

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                  this.Validate();
                this.vattuBindingSource.EndEdit();
                this.vattuTableAdapter.Update(this.dataSetDS.Vattu);
        }

        private void FormVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection = DBmanager.connection;
            this.vattuTableAdapter.Fill(this.dataSetDS.Vattu);

            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;
            log = new DataTableLog(dataSetDS.Vattu);


        }
        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            vattuTableAdapter.Fill(this.dataSetDS.Vattu);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            log.Redo();
            vattuBindingSource.MovePrevious();
            vattuBindingSource.MoveNext();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            log.Undo();
            vattuBindingSource.MovePrevious();
            vattuBindingSource.MoveNext();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            vattuTableAdapter.Fill(this.dataSetDS.Vattu);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)vattuBindingSource.Current).Row["SOLUONGTON"] = 0;
        }

        private void btnAddVT_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            ((DataRowView)vattuBindingSource.Current).Row["SOLUONGTON"] = 0;
        }


        private void btnCapNhatSLT_Click(object sender, EventArgs e)
        {
            string sql = "EXEC SP_CAPNHAT_TON";
            SqlTransaction tran;

            SqlCommand command = new SqlCommand(sql, DBmanager.connection);
            tran = DBmanager.connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
            command.Transaction = tran;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                btnReload_Click(null, null);
            }
            catch (SqlException ex)
            {
                tran.Rollback();
            }

        }
    }
    //public class DistributedTransactionUtility
    //{
    //    /// <summary>
    //    /// The Distributed Transaction method which creates a Transaction Scope object 
    //    ///  and commits if there is no error and rollbacks, incase of exception.
    //    /// </summary>
    //    /// <param name="method">
    //    ///  The method which performs multiple DB Transactions.
    //    /// 
    //    public void DoDistributedTransaction(Action method)
    //    {
    //        // Initializes Transaction Scope
    //        using (var transactionScope =
    //            new TransactionScope(TransactionScopeOption.Required,
    //            new TransactionOptions
    //            {
    //            // Default (Isolation Level) : Serializable - Introduces Severe Blocking and Deadlocks
    //            //  instead use ReadCommitted - Default Transaction Scope for SQL Server.
    //            IsolationLevel = System.Transactions.IsolationLevel.Serializable,
    //                Timeout = TransactionManager.DefaultTimeout
    //            }))
    //        {
    //            try
    //            {
    //                // Invokes the Method
    //                method();

    //                // Commits the Transaction
    //                transactionScope.Complete();
    //            }
    //            finally
    //            {
    //                // Irrespective of success or exception scenario, Transaction Scope must 
    //                // be disposed explicitly. Dispose method ends the transaction and clears 
    //                // any data related to it and also clears the scope object.
    //                transactionScope.Dispose();
    //            }
    //        }
    //    }
    //}
}