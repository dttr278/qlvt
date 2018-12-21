namespace QLVTr
{
    partial class Form1
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
            System.Windows.Forms.Label mACNLabel;
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.rpbtnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.rpbtnDMVT = new DevExpress.XtraBars.BarButtonItem();
            this.rpbtnSLTG = new DevExpress.XtraBars.BarButtonItem();
            this.rpbtnDHCN = new DevExpress.XtraBars.BarButtonItem();
            this.rpbtnNVHD = new DevExpress.XtraBars.BarButtonItem();
            this.rpbtnTHNX = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataSetDS = new QLVTr.DataSetDS();
            this.v_INFO_CNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_INFO_CNTableAdapter = new QLVTr.DataSetDSTableAdapters.V_INFO_CNTableAdapter();
            this.tableAdapterManager = new QLVTr.DataSetDSTableAdapters.TableAdapterManager();
            this.lbCN = new System.Windows.Forms.Label();
            this.cbxCN = new System.Windows.Forms.ComboBox();
            this.mACNLabel1 = new System.Windows.Forms.Label();
            this.panelCN = new System.Windows.Forms.Panel();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_INFO_CNBindingSource)).BeginInit();
            this.panelCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(261, 6);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 3;
            mACNLabel.Text = "MACN:";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNV,
            this.btnVT,
            this.btnKho,
            this.btnDH,
            this.btnPhieuXuat,
            this.btnPN,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barEditItem1,
            this.barSubItem1,
            this.rpbtnDSNV,
            this.rpbtnDMVT,
            this.rpbtnSLTG,
            this.rpbtnDHCN,
            this.rpbtnNVHD,
            this.rpbtnTHNX});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.ribbonControl1.Size = new System.Drawing.Size(990, 143);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân viên";
            this.btnNV.Id = 1;
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnVT
            // 
            this.btnVT.Caption = "Vật tư";
            this.btnVT.Id = 2;
            this.btnVT.Name = "btnVT";
            this.btnVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVT_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 3;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDH
            // 
            this.btnDH.Caption = "Đặt hàng";
            this.btnDH.Id = 6;
            this.btnDH.Name = "btnDH";
            this.btnDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDH_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu xuất";
            this.btnPhieuXuat.Id = 7;
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu nhập";
            this.btnPN.Id = 8;
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 22;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 23;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 24;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 25;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 26;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemComboBox2;
            this.barEditItem1.Id = 14;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 15;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // rpbtnDSNV
            // 
            this.rpbtnDSNV.Caption = "Danh sách nhân viên";
            this.rpbtnDSNV.Id = 16;
            this.rpbtnDSNV.Name = "rpbtnDSNV";
            this.rpbtnDSNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnDSNV_ItemClick);
            // 
            // rpbtnDMVT
            // 
            this.rpbtnDMVT.Caption = "Danh mục vật tư";
            this.rpbtnDMVT.Id = 17;
            this.rpbtnDMVT.Name = "rpbtnDMVT";
            this.rpbtnDMVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnDMVT_ItemClick);
            // 
            // rpbtnSLTG
            // 
            this.rpbtnSLTG.Caption = "Số lượng - trị giá hàng hóa";
            this.rpbtnSLTG.Id = 18;
            this.rpbtnSLTG.Name = "rpbtnSLTG";
            this.rpbtnSLTG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnSLTG_ItemClick);
            // 
            // rpbtnDHCN
            // 
            this.rpbtnDHCN.Caption = "Đơn đặt hàng chưa có phiếu nhập";
            this.rpbtnDHCN.Id = 19;
            this.rpbtnDHCN.Name = "rpbtnDHCN";
            this.rpbtnDHCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnDHCN_ItemClick);
            // 
            // rpbtnNVHD
            // 
            this.rpbtnNVHD.Caption = "Tình trạng hoạt động của nhân viên";
            this.rpbtnNVHD.Id = 20;
            this.rpbtnNVHD.Name = "rpbtnNVHD";
            this.rpbtnNVHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnNVHD_ItemClick);
            // 
            // rpbtnTHNX
            // 
            this.rpbtnTHNX.Caption = "Tổng hợp nhập xuất";
            this.rpbtnTHNX.Id = 21;
            this.rpbtnTHNX.Name = "rpbtnTHNX";
            this.rpbtnTHNX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rpbtnTHNX_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QLVT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVT);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDH);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPN);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPhieuXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Đơn hàng";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnDSNV);
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnDMVT);
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnSLTG);
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnDHCN);
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnNVHD);
            this.ribbonPageGroup6.ItemLinks.Add(this.rpbtnTHNX);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Báo cáo";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMaNV,
            this.lbHoTen,
            this.lbNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(48, 17);
            this.lbMaNV.Text = "MANV: ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(52, 17);
            this.lbHoTen.Text = "HOTEN: ";
            // 
            // lbNhom
            // 
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(51, 17);
            this.lbNhom.Text = "NHOM: ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Vật tư";
            // 
            // dataSetDS
            // 
            this.dataSetDS.DataSetName = "DataSetDS";
            this.dataSetDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_INFO_CNBindingSource
            // 
            this.v_INFO_CNBindingSource.DataMember = "V_INFO_CN";
            this.v_INFO_CNBindingSource.DataSource = this.dataSetDS;
            // 
            // v_INFO_CNTableAdapter
            // 
            this.v_INFO_CNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTr.DataSetDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Location = new System.Drawing.Point(3, 6);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(59, 13);
            this.lbCN.TabIndex = 2;
            this.lbCN.Text = "Chi nhánh:";
            // 
            // cbxCN
            // 
            this.cbxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCN.FormattingEnabled = true;
            this.cbxCN.Location = new System.Drawing.Point(68, 1);
            this.cbxCN.Name = "cbxCN";
            this.cbxCN.Size = new System.Drawing.Size(187, 21);
            this.cbxCN.TabIndex = 3;
            this.cbxCN.SelectedIndexChanged += new System.EventHandler(this.cbxCN_SelectedIndexChanged);
            // 
            // mACNLabel1
            // 
            this.mACNLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mACNLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_INFO_CNBindingSource, "MACN", true));
            this.mACNLabel1.Location = new System.Drawing.Point(307, 6);
            this.mACNLabel1.Name = "mACNLabel1";
            this.mACNLabel1.Size = new System.Drawing.Size(58, 13);
            this.mACNLabel1.TabIndex = 4;
            this.mACNLabel1.Text = "label1";
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(mACNLabel);
            this.panelCN.Controls.Add(this.mACNLabel1);
            this.panelCN.Controls.Add(this.cbxCN);
            this.panelCN.Controls.Add(this.lbCN);
            this.panelCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCN.Location = new System.Drawing.Point(0, 143);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(990, 25);
            this.panelCN.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 595);
            this.Controls.Add(this.panelCN);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_INFO_CNBindingSource)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbMaNV;
        private System.Windows.Forms.ToolStripStatusLabel lbHoTen;
        private System.Windows.Forms.ToolStripStatusLabel lbNhom;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnVT;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource v_INFO_CNBindingSource;
        private DataSetDS dataSetDS;
        private DataSetDSTableAdapters.V_INFO_CNTableAdapter v_INFO_CNTableAdapter;
        private DataSetDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelCN;
        private System.Windows.Forms.Label mACNLabel1;
        private System.Windows.Forms.ComboBox cbxCN;
        private System.Windows.Forms.Label lbCN;
        private DevExpress.XtraBars.BarButtonItem btnDH;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem btnPN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem rpbtnDSNV;
        private DevExpress.XtraBars.BarButtonItem rpbtnDMVT;
        private DevExpress.XtraBars.BarButtonItem rpbtnSLTG;
        private DevExpress.XtraBars.BarButtonItem rpbtnDHCN;
        private DevExpress.XtraBars.BarButtonItem rpbtnNVHD;
        private DevExpress.XtraBars.BarButtonItem rpbtnTHNX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

