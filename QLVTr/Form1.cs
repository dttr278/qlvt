using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVTr
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Login login;
        public Form1()
        {
            InitializeComponent();
            DBmanager.userDangNhap = new User();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDS.V_INFO_CN' table. You can move, or remove it, as needed.
            this.v_INFO_CNTableAdapter.Fill(this.dataSetDS.V_INFO_CN);
            try
            {
                string sql = "exec SP_INFOLOGIN @lgname = N'" + DBmanager.user + "'";
                SqlCommand c = new SqlCommand(sql, DBmanager.connection);
                SqlDataReader reader = c.ExecuteReader();
                reader.Read();
                lbMaNV.Text += reader.GetValue(0).ToString();
                DBmanager.userDangNhap.Id= reader.GetValue(0).ToString();
                lbHoTen.Text += reader.GetValue(1).ToString();
                DBmanager.userDangNhap.Name= reader.GetValue(1).ToString(); ;
                lbNhom.Text += reader.GetValue(2).ToString();
                DBmanager.userDangNhap.Role= reader.GetValue(2).ToString();
  
                reader.Close();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.cbxCN.DataSource = DBmanager.bindingCN;
            cbxCN.DisplayMember = "description";
            cbxCN.ValueMember = "subscriber_server";

            DBmanager.bindingMACN = v_INFO_CNBindingSource;

            v_INFO_CNTableAdapter.Connection.Close();
            v_INFO_CNTableAdapter.Connection = DBmanager.connection;
            v_INFO_CNTableAdapter.Fill(this.dataSetDS.V_INFO_CN);

            if (DBmanager.userDangNhap.Role.ToUpper() != "CONGTY")
            {
                panelCN.Visible = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormNV));
            if (f == null)
            {
                FormNV fnv = new FormNV();
                fnv.MdiParent = this;
                fnv.Show();
            }
            else f.Activate();

        }

        private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormVT));
            if (f == null)
            {
                FormVT fvt = new FormVT();
                fvt.MdiParent = this;
                fvt.Show();
            }
            else f.Activate();

        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormKho));
            if (f == null)
            {
                FormKho fk = new FormKho();
                fk.MdiParent = this;
                fk.Show();
            }
            else f.Activate();

        }

        private void cbxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCN.ValueMember != "")
            {
                string sql = DBmanager.sql;
                if (cbxCN.SelectedValue != null && cbxCN.SelectedValue.ToString() != DBmanager.cn)
                {
                    sql = "server=" + cbxCN.SelectedValue.ToString() + ";database=QLVT_DATHANG;user id=HTKN;password=123456";
                }
                DBmanager.connection.Close();
                DBmanager.connection.ConnectionString = sql;
                DBmanager.connection.Open();

                v_INFO_CNTableAdapter.Fill(this.dataSetDS.V_INFO_CN);
            }
        }

        private void btnDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormDH));
            if (f == null)
            {
                FormDH fdh = new FormDH();
                fdh.MdiParent = this;
                fdh.Show();
            }
            else f.Activate();
                
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormPX));
            if (f == null)
            {
               
                FormPX fpx = new FormPX();
                fpx.MdiParent = this;
                fpx.Show();
            }
            else f.Activate();

        }

        private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormPN));
            if (f == null)
            {
                FormPN fpn = new FormPN();
                fpn.MdiParent = this;
                fpn.Show();
            }
            else f.Activate();

        }

 
        private void rpbtnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RP_NV rpnv = new RP_NV();
            ReportPrintTool print = new ReportPrintTool(rpnv);
            print.ShowPreviewDialog();
        }

        private void rpbtnDMVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RP_VT xtraReportVT = new RP_VT();
            ReportPrintTool print = new ReportPrintTool(xtraReportVT);
            print.ShowPreviewDialog();
        }

        private void rpbtnDHCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RP_DDHChuaNhap rP_DDHChuaNhap = new RP_DDHChuaNhap();
            ReportPrintTool print = new ReportPrintTool(rP_DDHChuaNhap);
            print.ShowPreviewDialog();
        }

        private void rpbtnSLTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRPNX formRPNX = new FormRPNX();
            formRPNX.Show();
        }

        private void rpbtnNVHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRPHDNV formRPHDNV = new FormRPHDNV();
            formRPHDNV.Show();
        }

        private void rpbtnTHNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTH formTH = new FormTH();
            formTH.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

    }

}
