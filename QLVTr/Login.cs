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
using System.Data.SqlClient;

namespace QLVTr
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_CN' table. You can move, or remove it, as needed.
            this.v_CNTableAdapter.Fill(this.dataSetMaster.V_CN);
            DBmanager.bindingCN = this.v_CNBindingSource;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBmanager.cn = v_CNComboBox.SelectedValue.ToString();
            DBmanager.user = txbUser.Text;
            DBmanager.pass = txbPass.Text;
            DBmanager.sql = "server=" + DBmanager.cn + ";database=QLVT_DATHANG;user id="+ DBmanager.user + ";password="+ DBmanager.pass;

            DBmanager.connection = new SqlConnection(DBmanager.sql);
            try
            {
                DBmanager.connection.Open();
                Form1 f1 = new Form1();
                f1.login = this;
                f1.Show();
                this.Hide();
                //f1.Parent = this;
            }
            catch ( SqlException ex)
            {
                MessageBox.Show("that bai");
            }
        }

        
    }
}