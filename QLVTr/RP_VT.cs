using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_VT : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_VT()
        {
            InitializeComponent();
            dataSetDS1.EnforceConstraints = false;
            this.vattuTableAdapter.Connection = DBmanager.connection;
            this.vattuTableAdapter.Fill(dataSetDS1.Vattu);
        }

    }
}
