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
    public partial class FormPN : DevExpress.XtraEditors.XtraForm
    {
        public FormPN()
        {
            InitializeComponent();
            if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                btnAddPN.Enabled = false;
                btnAddCTPN.Enabled = false;
                gridView3.OptionsBehavior.ReadOnly = true;
                gridView4.OptionsBehavior.ReadOnly = true;
                this.dataSetDS.EnforceConstraints = false;
                this.btnSave.Enabled = false;
            }
        }

        private void FormPN_Load(object sender, EventArgs e)
        {

            if (DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
                PreFill();
           
            Fill();

            repositoryItemMaVT.DataSource = cTDDHBindingSource;
            repositoryItemMaVT.ValueMember = "MAVT";
            repositoryItemMaVT.DisplayMember = "MAVT";

            dataSetDS.CTPN.ColumnChanged += onColumnChanged;

            repositoryItemMK.DataSource = dataSetDS.Kho.ToList();
            repositoryItemMK.ValueMember = "MAKHO";
            repositoryItemMK.DisplayMember = "MAKHO";

            DBmanager.bindingCN.CurrentChanged += OnCurrentChangedBindingCN;

            this.cTPNTableAdapter.Adapter.RowUpdating += Adapter_RowUpdating;
            this.cTPNTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }
        void OnCurrentChangedBindingCN(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
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


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dataSetDS);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                btnRefresh_ItemClick(null, null);
            }
          
        }

        private void Adapter_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
           
            //tran = DBmanager.connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
            //command.Transaction = tran;
            //try
            //{
            //    command.ExecuteNonQuery();
            //    tran.Commit();
            //    btnReload_Click(null, null);
            //}
            //catch (SqlException ex)
            //{
            //    tran.Rollback();
            //}


        }

        private void Adapter_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            //if (e.StatementType == StatementType.Insert)
            //{
            //    string sql = "EXEC SP_SLVT @mavt = N'" + e.Row["MAVT"] + "', @sl = " + e.Row["SOLUONG"];
            //    //SqlTransaction tran;

            //    SqlCommand command = new SqlCommand(sql, DBmanager.connection);
            //    command.ExecuteNonQuery();

            //}
        }
    

        bool iChange = false;
        void onColumnChanged(object sender, DataColumnChangeEventArgs e)
        {

            if (e.Row.RowState != DataRowState.Modified && e.Column.ColumnName == "SOLUONG")
            {
                if (iChange)
                    return;
                int sl = Convert.ToInt32(((DataRowView)cTPNBindingSource.Current).Row[e.Column].ToString());
                int i = repositoryItemMaVT.GetIndexByKeyValue(((DataRowView)cTPNBindingSource.Current).Row["MAVT"]);
                if (i < 0)
                {
                    MessageBox.Show("Nhập mã vật tư trước khi nhập số lượng!");
                    iChange = true;
                    ((DataRowView)cTPNBindingSource.Current).Row[e.Column] = DBNull.Value;
                    iChange = false;
                }
                else
                {
                    int range = Convert.ToInt32(((DataRowView)cTDDHBindingSource.List[i]).Row["SOLUONG"].ToString());
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

        private void gridView3_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView3.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle &&
                ((DataRowView)phieuNhapBindingSource.Current).Row.RowState != DataRowState.Added)
            {
                e.Cancel = true;
                btnRemovePN.Enabled = false;
            }
            else
            {
                btnRemovePN.Enabled = true;
            }
        }

        private void phieuNhapBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindingSource bindingSource = (BindingSource)sender;
            btnRemovePN.Enabled = false;
            if (bindingSource.Count != 0)
            {
                this.btnAddPN.Enabled = false;
            }
            else
            {
                this.btnAddPN.Enabled = true;
            }
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            gridView3.AddNewRow();
            if(phieuNhapBindingSource.Current!=null)
                ((DataRowView)phieuNhapBindingSource.Current).Row["MANV"] = DBmanager.userDangNhap.Id;
        }


        private void btnAddCTPN_Click(object sender, EventArgs e)
        {
            gridView4.AddNewRow();
        }

        private void gridView4_ShowingEditor(object sender, CancelEventArgs e)
        {
            //if (gridView4.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle
            //    && ((DataRowView)cTPNBindingSource.Current).Row.RowState != DataRowState.Added)
            //{
            //    e.Cancel = true;
            //    btnRemoveCTPN.Enabled = false;
            //}
            //else
            //{
            //    btnRemoveCTPN.Enabled = true;
            //}
        }

        private void cTPNBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //btnRemoveCTPN.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
            {
                dataSetDS.EnforceConstraints = false;
                PreFill();
                repositoryItemMaVT.DataSource =cTDDHBindingSource;
                repositoryItemMK.DataSource = dataSetDS.Kho.ToList();
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
            this.cTDDHTableAdapter.Connection=
            this.cTPNTableAdapter.Connection=
            this.phieuNhapTableAdapter.Connection=
            this.datHangTableAdapter.Connection = DBmanager.connection;

            this.datHangTableAdapter.Fill(this.dataSetDS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.dataSetDS.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.dataSetDS.CTPN);
            this.cTDDHTableAdapter.Fill(this.dataSetDS.CTDDH);
        }
    }
}