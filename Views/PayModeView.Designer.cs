namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            LblSearch = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 39);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 2;
            label1.Text = "PLAY MODE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(LblSearch);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 292);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            tabPagePayModeList.Click += tabPage1_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(604, 235);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(167, 40);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(604, 177);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(167, 40);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(604, 121);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(167, 40);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(604, 65);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(167, 40);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(26, 87);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgPayMode.Size = new Size(543, 188);
            DgPayMode.TabIndex = 3;
            DgPayMode.CellContentClick += DgPayMode_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(521, 44);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(35, 37);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(26, 49);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(465, 27);
            TxtSearch.TabIndex = 1;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Location = new Point(26, 11);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(122, 40);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "Search Pay Mode\n\n";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 292);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(208, 241);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 41);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(31, 239);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(132, 45);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(18, 164);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Enter observation";
            TxtPayModeObservation.Size = new Size(561, 69);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 141);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 4;
            label4.Text = "Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(18, 100);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Enter pay mode name";
            TxtPayModeName.Size = new Size(240, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 77);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(18, 38);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(240, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Pay Mode ID";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label LblSearch;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtPayModeId;
        private Label label2;
        private TextBox TxtPayModeObservation;
        private Label label4;
        private TextBox TxtPayModeName;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}