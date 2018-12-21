using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_NV : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_NV()
        {
            InitializeComponent();
            this.dataSetDS1.EnforceConstraints = false;
            this.v_NVTableAdapter.Connection = DBmanager.connection;
            this.v_NVTableAdapter.Fill(this.dataSetDS1.V_NV);
        }

    }
}
