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

namespace QLVTr
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        public FormKho()
        {
            InitializeComponent();
            if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                this.btnAddKho.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnUndo.Visible = false;
                this.btnRedo.Visible = false;
                this.gridView1.OptionsBehavior.ReadOnly = true;
            }
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDS);

        }

        DataTableLog log;
        private void FormKho_Load(object sender, EventArgs e)
        {

            if (tableAdapterManager.ChiNhanhTableAdapter == null)
                tableAdapterManager.ChiNhanhTableAdapter = new DataSetDSTableAdapters.ChiNhanhTableAdapter();
            tableAdapterManager.ChiNhanhTableAdapter.Connection.Close();
            tableAdapterManager.ChiNhanhTableAdapter.Connection = DBmanager.connection; ;
            tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);

            // TODO: This line of code loads data into the 'dataSetDS.Kho' table. You can move, or remove it, as needed.
            khoTableAdapter.Connection.Close();
            khoTableAdapter.Connection = DBmanager.connection;
            this.khoTableAdapter.Fill(this.dataSetDS.Kho);

            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;

            log = new DataTableLog(dataSetDS.Kho);
        }
        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            this.dataSetDS.Kho.Clear();
            tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);
            khoTableAdapter.Fill(this.dataSetDS.Kho);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            log.Undo();
            khoBindingSource.MovePrevious();
            khoBindingSource.MoveNext();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            log.Redo();
            khoBindingSource.MovePrevious();
            khoBindingSource.MoveNext();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.dataSetDS.Kho.Clear();
            tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);
            khoTableAdapter.Fill(this.dataSetDS.Kho);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)khoBindingSource.Current).Row["MACN"] = ((DataRowView)DBmanager.bindingMACN.Current)["MACN"].ToString();
        }

        private void btnAddKho_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            ((DataRowView)khoBindingSource.Current).Row["MACN"] = ((DataRowView)DBmanager.bindingMACN.Current)["MACN"].ToString(); 
        }

    }
}