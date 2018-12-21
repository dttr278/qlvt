using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_TONGHOP : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_TONGHOP()
        {
            InitializeComponent();
        }
        public RP_TONGHOP(string start,string end)
        {
            InitializeComponent();
            this.sP_THNXTableAdapter.Connection = DBmanager.connection;
            this.sP_THNXTableAdapter.Fill(this.dataSetDS1.SP_THNX, start, end);
            this.lbDate.Text = start + " đến " + end;
        }

    }
}
