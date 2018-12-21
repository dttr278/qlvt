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
    public partial class FormPX : DevExpress.XtraEditors.XtraForm
    {
        public FormPX()
        {
            InitializeComponent();
            if(DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                dataSetDS.EnforceConstraints = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
                btnAddPX.Enabled = false;
                btnAddCTPX.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.cTPXBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDS);

        }

        private void FormPX_Load(object sender, EventArgs e)
        {
            if (DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
            {
                PreFill();
                Fill();
                repositoryItemMaKho.DataSource = dataSetDS.Kho.ToList();
                repositoryItemMaKho.DisplayMember = "MAKHO";
                repositoryItemMaKho.ValueMember = "MAKHO";

                repositoryItemMAVT.DataSource = dataSetDS.Vattu.ToList();
                repositoryItemMAVT.DisplayMember = "MAVT";
                repositoryItemMAVT.ValueMember = "MAVT";
            }
            else
            {
                Fill();
            }
            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;
            dataSetDS.CTPX.ColumnChanged += CTPX_ColumnChanged;
        }

        bool iChange=false;
        private void CTPX_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Row.RowState != DataRowState.Modified && e.Column.ColumnName == "SOLUONG")
            {
                if (iChange)
                    return;
                int sl = Convert.ToInt32(((DataRowView)cTPXBindingSource.Current).Row[e.Column].ToString());
                int i = repositoryItemMAVT.GetIndexByKeyValue(((DataRowView)cTPXBindingSource.Current).Row["MAVT"]);
                if (i < 0)
                {
                    MessageBox.Show("Nhập mã vật tư trước khi nhập số lượng!");
                    iChange = true;
                    ((DataRowView)cTPXBindingSource.Current).Row[e.Column] = DBNull.Value;
                    iChange = false;
                }
                else
                {
                    string mavt = ((DataRowView)cTPXBindingSource.Current).Row["MAVT"].ToString();
                    int range = dataSetDS.Vattu.ToList().Find(x=> x.MAVT.Contains(mavt)).SOLUONGTON;
                    if (sl > range)
                    {
                        MessageBox.Show("Số lượng phải nhỏ hơn hoặc bằng " + range);
                        e.Row.SetColumnError(e.Column, "Số lượng phải nhỏ hơn hoặc bằng " + range);
                    }
                    else
                    {
                        e.Row.ClearErrors();
                    }

                }

            }
        }

        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            barButtonItem2_ItemClick(null, null);
        }

        void Fill()
        {
            this.cTPXTableAdapter.Connection=
                this.phieuXuatTableAdapter.Connection = DBmanager.connection;

            this.phieuXuatTableAdapter.Fill(this.dataSetDS.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.dataSetDS.CTPX);
        }
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

        private void btnAddPX_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            ((DataRowView)phieuXuatBindingSource.Current)["MANV"] = DBmanager.userDangNhap.Id;
        }

        private void btnAddCTPX_Click(object sender, EventArgs e)
        {
            gridView2.AddNewRow();
        }



        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView1.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle
               && ((DataRowView)phieuXuatBindingSource.Current).Row.RowState != DataRowState.Added)
            {
                e.Cancel = true;
                btnRemovePX.Enabled = false;
            }
            else
            {
                btnRemovePX.Enabled = true;
            }
        }

        private void phieuXuatBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnRemovePX.Enabled = false;
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            //if (gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle
            //   && ((DataRowView)cTPXBindingSource.Current).Row.RowState != DataRowState.Added)
            //{
            //    e.Cancel = true;
            //    btnRemoveCTPX.Enabled = false;
            //}
            //else
            //{
            //    btnRemoveCTPX.Enabled = true;
            //}
        }

        private void cTPXBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //btnRemoveCTPX.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.cTPXBindingSource.EndEdit(); 
          

            try
            {
                this.phieuXuatTableAdapter.Update(dataSetDS.PhieuXuat);
                this.cTPXTableAdapter.Update(dataSetDS.CTPX);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //refresh
                barButtonItem2_ItemClick(null, null);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                Fill();
            }
            else
            {
                dataSetDS.EnforceConstraints = false;
                PreFill();
                Fill();
                repositoryItemMAVT.DataSource = dataSetDS.Vattu.ToList();
                repositoryItemMaKho.DataSource = dataSetDS.Kho.ToList();
                dataSetDS.EnforceConstraints = true;

            }
        }
    }
}