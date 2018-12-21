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

namespace QLVTr
{
    public partial class FormDH : DevExpress.XtraEditors.XtraForm

    {
        //DataTableLog log;
        public FormDH()
        {
            InitializeComponent();

            if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                bindingNavigator1.Visible = false;
                bindingNavigator2.Visible = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
                this.dataSetDS.EnforceConstraints = false;
                this.btnSave.Enabled = false;
            }
        }
      

        private void FormDH_Load(object sender, EventArgs e)
        {

            if(DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
                PreFill();
            Fill();


            repositoryItem.DataSource = dataSetDS.Kho.ToList();
            repositoryItem.ValueMember = "MAKHO";
            repositoryItem.DisplayMember = "MAKHO";

            repositoryItemMAVT.DataSource = dataSetDS.Vattu.ToList();
            repositoryItemMAVT.ValueMember = "MAVT";
            repositoryItemMAVT.DisplayMember = "MAVT";

            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;
            //log = new DataTableLog(this.dataSetDS.DatHang);
        }

        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }


        //private void btnUndo_Click(object sender, EventArgs e)
        //{
        //    log.Undo();
        //}

        //private void btnRedo_Click(object sender, EventArgs e)
        //{
        //    log.Redo();
        //}

        //private void cTDDHGridControl_DataSourceChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("change");
        //}

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.cTDDHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDS);
        }

        //private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.datHangBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSetDS);

        //}

        //private void datHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.datHangBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSetDS);

        //}
        void PreFill()
        {

            if (this.tableAdapterManager.ChiNhanhTableAdapter == null)
                this.tableAdapterManager.ChiNhanhTableAdapter = new DataSetDSTableAdapters.ChiNhanhTableAdapter();
            if (this.tableAdapterManager.KhoTableAdapter == null)
                this.tableAdapterManager.KhoTableAdapter = new DataSetDSTableAdapters.KhoTableAdapter();
            if (this.tableAdapterManager.NhanVienTableAdapter == null)
                this.tableAdapterManager.NhanVienTableAdapter = new DataSetDSTableAdapters.NhanVienTableAdapter();
            if (this.tableAdapterManager.VattuTableAdapter == null)
                this.tableAdapterManager.VattuTableAdapter = new DataSetDSTableAdapters.VattuTableAdapter();

            this.tableAdapterManager.ChiNhanhTableAdapter.Connection =
                 this.tableAdapterManager.KhoTableAdapter.Connection =
                 this.tableAdapterManager.NhanVienTableAdapter.Connection =
                 this.tableAdapterManager.VattuTableAdapter.Connection = DBmanager.connection;

            this.tableAdapterManager.ChiNhanhTableAdapter.Fill(this.dataSetDS.ChiNhanh);
            this.tableAdapterManager.KhoTableAdapter.Fill(this.dataSetDS.Kho);
            this.tableAdapterManager.NhanVienTableAdapter.Fill(this.dataSetDS.NhanVien);
            this.tableAdapterManager.VattuTableAdapter.Fill(this.dataSetDS.Vattu);

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
            {
                dataSetDS.EnforceConstraints = false;

                PreFill();
                repositoryItem.DataSource = dataSetDS.Kho.ToList();
                repositoryItemMAVT.DataSource = dataSetDS.Vattu.ToList();

                Fill();

                dataSetDS.EnforceConstraints = true;
            }
            else
            {
                Fill();
            }

        }

        void Fill()
        {
            this.datHangTableAdapter.Connection =
                this.cTDDHTableAdapter.Connection = DBmanager.connection;

            this.datHangTableAdapter.Fill(this.dataSetDS.DatHang);
            this.cTDDHTableAdapter.Fill(this.dataSetDS.CTDDH);
        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView1.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle
               && ((DataRowView)datHangBindingSource.Current).Row.RowState != DataRowState.Added)
            {
                e.Cancel = true;
                btnRemoveDH.Enabled = false;
            }
            else
            {
                btnRemoveDH.Enabled = true;
            }
        }

        private void datHangBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
       
                btnRemoveDH.Enabled = false;
            
        }

        private void btnAddDH_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            ((DataRowView)datHangBindingSource.Current)["MANV"] = DBmanager.userDangNhap.Id;
        }

        private void btnAddCTDH_Click(object sender, EventArgs e)
        {
            gridView2.AddNewRow();
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle
              && ((DataRowView)cTDDHBindingSource.Current).Row.RowState != DataRowState.Added)
            {
                e.Cancel = true;
                btnRemoveCTDH.Enabled = false;
            }
            else
            {
                btnRemoveCTDH.Enabled = true;
            }
        }

        private void cTDDHBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
           
            btnRemoveCTDH.Enabled = false;
            
        }

        private void btnRemoveDH_Click(object sender, EventArgs e)
        {
            datHangBindingSource.RemoveCurrent();
        }

        private void btnRemoveCTDH_Click(object sender, EventArgs e)
        {
            cTDDHBindingSource.RemoveCurrent();
        }
    }
}