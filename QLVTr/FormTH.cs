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
    public partial class FormTH : DevExpress.XtraEditors.XtraForm
    {
        public FormTH()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("dd/M/yyyy");
            string end = dateTimePicker2.Value.ToString("dd/M/yyyy");
            RP_TONGHOP rP_TONGHOP = new RP_TONGHOP( start, end);
            ReportPrintTool print = new ReportPrintTool(rP_TONGHOP);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}