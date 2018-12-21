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
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class FormRPHDNV : DevExpress.XtraEditors.XtraForm
    {
        public FormRPHDNV()
        {
            InitializeComponent();
            cbxMaNV.DisplayMember = "MANV";
            cbxMaNV.ValueMember = "MANV";
           
        }

   

        private void FormRPHDNV_Load(object sender, EventArgs e)
        {
            this.dataSetDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetDS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection = DBmanager.connection;
            this.nhanVienTableAdapter.Fill(this.dataSetDS.NhanVien);

        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("dd/M/yyyy");
            string end = dateTimePicker2.Value.ToString("dd/M/yyyy");
            RP_HDNV1 rP_HDNV1 = new RP_HDNV1((int)cbxMaNV.SelectedValue, start, end);
            ReportPrintTool print = new ReportPrintTool(rP_HDNV1);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}