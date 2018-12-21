using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace QLVTr
{
    public partial class RP_HDNV1 : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_HDNV1()
        {
            InitializeComponent();
        }

        public RP_HDNV1(int maNV, string start, string end)
        {
            InitializeComponent();
            this.dataSetDS1.EnforceConstraints = false;
            this.sP_DHNVTableAdapter.Connection = DBmanager.connection;
            this.sP_DHNVTableAdapter.Fill(dataSetDS1.SP_DHNV, maNV, start, end);
            string sql = "SELECT MANV,HOTEN=HO+' '+TEN,DIACHI,NGAYSINH ,LUONG FROM dbo.NhanVien WHERE MANV=" + maNV;
            SqlCommand command = new SqlCommand(sql, DBmanager.connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    lbMANV.Text = ((int)reader.GetValue(0)).ToString();
                    lbHoTen.Text = (string)reader.GetValue(1);
                    lbDC.Text = (string)reader.GetValue(1);
                    lbNgaySinh.Text = ((DateTime)reader.GetValue(3)).GetDateTimeFormats()[10];
                    lbLuong.Text = ((double)reader.GetValue(4)).ToString();
                }
            }

        }
    }
}
