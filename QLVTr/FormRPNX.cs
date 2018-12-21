using System;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class FormRPNX : DevExpress.XtraEditors.XtraForm
    {
        public FormRPNX()
        {
            InitializeComponent();
            comboBoxLoai.SelectedIndex = 0;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("dd/M/yyyy");
            string end = dateTimePicker2.Value.ToString("dd/M/yyyy");
            int ct = 0;
            if (DBmanager.userDangNhap.Role == "CONGTY")
                ct = 1;
            if (comboBoxLoai.SelectedIndex == 0)
            {
                RP_TKPN rP_TKPN = new RP_TKPN(start, end, ct);
                ReportPrintTool print = new ReportPrintTool(rP_TKPN);
                print.ShowPreviewDialog();
            }
            else
            {
                RP_TKPX rP_TKPX = new RP_TKPX(start, end, ct);
                ReportPrintTool print = new ReportPrintTool(rP_TKPX);
                print.ShowPreviewDialog();
            }
        }
    }
}