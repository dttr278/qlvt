using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_TKPN : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_TKPN()
        {
            InitializeComponent();
        }
        public RP_TKPN(string startDay, string endDate,int isCt)
        {
            InitializeComponent();
            this.sP_TKPNTableAdapter.Connection = DBmanager.connection;
            this.sP_TKPNTableAdapter.Fill(this.dataSetDS1.SP_TKPN, startDay, endDate,isCt);
            this.lbDate.Text = startDay + " đến " + endDate;
        }

    }
}
