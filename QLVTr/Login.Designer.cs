namespace QLVTr
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSetMaster = new QLVTr.DataSetMaster();
            this.v_CNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_CNTableAdapter = new QLVTr.DataSetMasterTableAdapters.V_CNTableAdapter();
            this.tableAdapterManager = new QLVTr.DataSetMasterTableAdapters.TableAdapterManager();
            this.v_CNComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_CNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetMaster
            // 
            this.dataSetMaster.DataSetName = "DataSetMaster";
            this.dataSetMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_CNBindingSource
            // 
            this.v_CNBindingSource.DataMember = "V_CN";
            this.v_CNBindingSource.DataSource = this.dataSetMaster;
            // 
            // v_CNTableAdapter
            // 
            this.v_CNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVTr.DataSetMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_CNComboBox
            // 
            this.v_CNComboBox.DataSource = this.v_CNBindingSource;
            this.v_CNComboBox.DisplayMember = "description";
            this.v_CNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_CNComboBox.FormattingEnabled = true;
            this.v_CNComboBox.Location = new System.Drawing.Point(123, 48);
            this.v_CNComboBox.Name = "v_CNComboBox";
            this.v_CNComboBox.Size = new System.Drawing.Size(245, 21);
            this.v_CNComboBox.TabIndex = 1;
            this.v_CNComboBox.ValueMember = "subscriber_server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi nhanh:";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(123, 91);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(245, 21);
            this.txbUser.TabIndex = 3;
            this.txbUser.Text = "lt";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(123, 135);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(245, 21);
            this.txbPass.TabIndex = 4;
            this.txbPass.Text = "1";
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(293, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_CNComboBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_CNBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetMaster dataSetMaster;
        private System.Windows.Forms.BindingSource v_CNBindingSource;
        private DataSetMasterTableAdapters.V_CNTableAdapter v_CNTableAdapter;
        private DataSetMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox v_CNComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
    }
}