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
    public partial class LoginSettingForm : DevExpress.XtraEditors.XtraForm
    {
        string manv,login;
        bool isNew;
        public LoginSettingForm(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            this.cbxRole.DisplayMember = "Text";
            this.cbxRole.ValueMember = "Value";
            if (DBmanager.userDangNhap.Role.ToUpper() == "CHINHANH")
            {
                // Bind combobox to dictionary
                //Dictionary<string, string> test = new Dictionary<string, string>();
                //test.Add("CHINHANH", "CHINHANH");
                //test.Add("USER", "USER");
                //this.cbxRole.DataSource = new BindingSource(test, null);
                //this.cbxRole.DisplayMember = "Value";
                //this.cbxRole.ValueMember = "Key";


                this.cbxRole.Items.Add(new { Text = "CHINHANH", Value = "CHINHANH" });
                this.cbxRole.Items.Add(new { Text = "USER", Value = "USER" });

            }
            else if (DBmanager.userDangNhap.Role.ToUpper() == "CONGTY")
            {
                //this.cbxRole.Items.Add("CONGTY");
                //Dictionary<string, string> test = new Dictionary<string, string>();
                //test.Add("CONGTY", "CONGTY");
                //this.cbxRole.DataSource = new BindingSource(test, null);
                //this.cbxRole.DisplayMember = "Value";
                //this.cbxRole.ValueMember = "Key";
                this.cbxRole.Items.Add(new { Text = "CONGTY", Value = "CONGTY" });
            }
        }

        private void LoginSettingForm_Load(object sender, EventArgs e)
        {
            login = GetLogin();

            if (login != null)
            {
                if (manv == DBmanager.userDangNhap.Id)
                {
                    isNew = false;
                    txbLogin.Text = login;
                    //   txbLogin.ReadOnly = true;
                    txbLogin.Enabled = false;
                    cbxRole.Visible = false;
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Nhân viên này đã có login("+login+")!");
                }
               
            }
            else
            {
                isNew = true;
                //MessageBox.Show("Nhân viên này chưa có tài khoản. Hãy tạo mới!");
                this.cbxRole.SelectedIndex = 0;
            }
        }

        string GetLogin()
        {
            string rs = null;
            string sql = "SP_GETLOGIN";
            SqlCommand commander = new SqlCommand(sql, DBmanager.connection);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.AddWithValue("@manv", manv);

            SqlDataReader reader = commander.ExecuteReader();

            if (reader.Read()&& reader.HasRows){
                rs= reader.GetValue(0).ToString();
                reader.Close();
            }
            return rs;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txbLogin.Text = txbLogin.Text.Trim();
            if (txbPassword.Text != txbRepassword.Text)
            {
                MessageBox.Show("Password không trùng khớp!");
                return;
            }
            if (txbLogin.Text.Length==0)
            {
                MessageBox.Show("Login không được bỏ trống!");
                return;
            }
            if (isNew == true)
            {
                int rs=CreateLogin(txbLogin.Text, txbPassword.Text, manv, cbxRole.SelectedItem.ToString());
                if (rs == 0)
                {
                    MessageBox.Show("Thành công!");
                    this.LoginSettingForm_Load(this,new EventArgs());
                }
                else if (rs == 1)
                {
                    MessageBox.Show("Login trùng!");
                }  
            }
            else
            {
                MessageBox.Show("^^");
            }
        }

        int CreateLogin(string lgName,string passWord,string username,string role)
        {
            int rs = -1;
            string sql = "SP_TAOTAIKHOAN";
            SqlCommand commander = new SqlCommand(sql, DBmanager.connection);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.AddWithValue("@LGNAME", lgName);
            commander.Parameters.AddWithValue("@PASS", passWord);
            commander.Parameters.AddWithValue("@USERNAME", username);
            commander.Parameters.AddWithValue("@ROLE", role);

            SqlParameter retVal = new SqlParameter("@return", SqlDbType.Int);
            retVal.Direction = ParameterDirection.Output;
            retVal.Value = -1;
            commander.Parameters.Add(retVal);

            SqlDataReader reader = commander.ExecuteReader();
            reader.Read();
            reader.Close();
            rs = Convert.ToInt32(retVal.Value);
             
            return rs;
        }
    }
}