using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTr
{
    public partial class RP_DDHChuaNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_DDHChuaNhap()
        {
            InitializeComponent();
            this.sP_DDH_CHUA_NHAPTableAdapter.Connection = DBmanager.connection;
            this.sP_DDH_CHUA_NHAPTableAdapter.Fill(this.dataSetDS1.SP_DDH_CHUA_NHAP);


        }

    }
}
