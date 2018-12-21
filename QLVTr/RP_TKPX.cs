using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_TKPX : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_TKPX()
        {
            InitializeComponent();
        }
        public RP_TKPX(string startDay, string endDate, int isCt)
        {
            InitializeComponent();
            this.sP_TKPXTableAdapter.Connection = DBmanager.connection;
            this.sP_TKPXTableAdapter.Fill(this.dataSetDS1.SP_TKPX, startDay, endDate, isCt);
            this.lbDate.Text = startDay + " đến " + endDate;
        }
    }
}
