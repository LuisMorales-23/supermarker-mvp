namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            panel2 = new Panel();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            tabPageCategoriesDetail = new TabPage();
            TxtCategoriesDescription = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 27);
            label1.Name = "label1";
            label1.Size = new Size(210, 45);
            label1.TabIndex = 1;
            label1.Text = "CATEGORIES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(22, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(panel2);
            tabPageCategoriesList.Controls.Add(DgPayMode);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(pictureBox2);
            tabPageCategoriesList.Location = new Point(4, 24);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 320);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnClose);
            panel2.Controls.Add(BtnDelete);
            panel2.Controls.Add(BtnEdit);
            panel2.Controls.Add(BtnNew);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(572, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 298);
            panel2.TabIndex = 4;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(32, 226);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(145, 59);
            BtnClose.TabIndex = 3;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(32, 147);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(145, 61);
            BtnDelete.TabIndex = 2;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.ForeColor = SystemColors.ControlLightLight;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(32, 77);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(145, 55);
            BtnEdit.TabIndex = 1;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(32, 13);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(145, 53);
            BtnNew.TabIndex = 0;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(20, 65);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(526, 247);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.weui__arrow_filled__1_;
            BtnSearch.Location = new Point(497, 24);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(49, 28);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(58, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Categories";
            TxtSearch.RightToLeft = RightToLeft.Yes;
            TxtSearch.Size = new Size(433, 23);
            TxtSearch.TabIndex = 1;
            TxtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ic__baseline_search;
            pictureBox2.Location = new Point(18, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Controls.Add(label2);
            tabPageCategoriesDetail.Location = new Point(4, 24);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 320);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Details";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(26, 177);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.PlaceholderText = "Categorie Description";
            TxtCategoriesDescription.Size = new Size(276, 56);
            TxtCategoriesDescription.TabIndex = 7;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(24, 110);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Categorie Name";
            TxtCategoriesName.Size = new Size(278, 23);
            TxtCategoriesName.TabIndex = 6;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(22, 44);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.PlaceholderText = "0";
            TxtCategoriesId.Size = new Size(124, 23);
            TxtCategoriesId.TabIndex = 5;
            TxtCategoriesId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(153, 257);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(97, 46);
            BtnCancel.TabIndex = 4;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(26, 256);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(97, 46);
            BtnSave.TabIndex = 3;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 153);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 2;
            label4.Text = "Categorie Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 89);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Categorie Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 26);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Categorie Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private TextBox TxtSearch;
        private PictureBox pictureBox2;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private TextBox TxtCategoriesDescription;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
    }
}