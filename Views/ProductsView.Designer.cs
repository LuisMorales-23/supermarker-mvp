namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
            tabPageProductsList = new TabPage();
            BtnSearch = new Button();
            DgProducts = new DataGridView();
            panel2 = new Panel();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductsDetail = new TabPage();
            TxtProductStock = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductsCategorie = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtProductsPrice = new TextBox();
            TxtProductsName = new TextBox();
            TxtProductsid = new TextBox();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(panel2);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(pictureBox2);
            tabPageProductsList.Location = new Point(4, 24);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(792, 294);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.weui__arrow_filled__1_;
            BtnSearch.Location = new Point(494, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(64, 29);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(14, 58);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.Size = new Size(552, 222);
            DgProducts.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(BtnClose);
            panel2.Controls.Add(BtnDelete);
            panel2.Controls.Add(BtnEdit);
            panel2.Controls.Add(BtnNew);
            panel2.Location = new Point(585, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 280);
            panel2.TabIndex = 3;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(25, 212);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(145, 53);
            BtnClose.TabIndex = 3;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(25, 144);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(145, 53);
            BtnDelete.TabIndex = 2;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(25, 79);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(145, 53);
            BtnEdit.TabIndex = 1;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(25, 18);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(145, 53);
            BtnNew.TabIndex = 0;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(55, 24);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Product";
            TxtSearch.Size = new Size(432, 23);
            TxtSearch.TabIndex = 2;
            TxtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ic__baseline_search;
            pictureBox2.Location = new Point(10, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 128);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(17, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 40);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 322);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtProductStock);
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(TxtProductsCategorie);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Controls.Add(label2);
            tabPageProductsDetail.Controls.Add(TxtProductsPrice);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsid);
            tabPageProductsDetail.Location = new Point(4, 24);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 294);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(118, 185);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.Size = new Size(147, 23);
            TxtProductStock.TabIndex = 13;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(352, 122);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(144, 50);
            BtnCancel.TabIndex = 12;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(352, 35);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(144, 50);
            BtnSave.TabIndex = 11;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsCategorie
            // 
            TxtProductsCategorie.Location = new Point(136, 230);
            TxtProductsCategorie.Name = "TxtProductsCategorie";
            TxtProductsCategorie.PlaceholderText = "Product Categorie";
            TxtProductsCategorie.Size = new Size(129, 23);
            TxtProductsCategorie.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 236);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 7;
            label6.Text = "Categorie Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 190);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Product Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 137);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Product Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 43);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Id";
            // 
            // TxtProductsPrice
            // 
            TxtProductsPrice.Location = new Point(119, 137);
            TxtProductsPrice.Name = "TxtProductsPrice";
            TxtProductsPrice.PlaceholderText = "Product Price";
            TxtProductsPrice.Size = new Size(130, 23);
            TxtProductsPrice.TabIndex = 2;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(118, 83);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Product Name";
            TxtProductsName.Size = new Size(124, 23);
            TxtProductsName.TabIndex = 1;
            // 
            // TxtProductsid
            // 
            TxtProductsid.Location = new Point(118, 35);
            TxtProductsid.Name = "TxtProductsid";
            TxtProductsid.PlaceholderText = " 0";
            TxtProductsid.Size = new Size(122, 23);
            TxtProductsid.TabIndex = 0;
            TxtProductsid.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products Manegement";
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox TxtSearch;
        private TabControl tabControl1;
        private TabPage tabPageProductsDetail;
        private Button BtnSearch;
        private DataGridView DgProducts;
        private Panel panel2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label2;
        private TextBox TxtProductsPrice;
        private TextBox TxtProductsName;
        private TextBox TxtProductsid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductStock;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsCategorie;
        private TabPage tabPageProductsList;
    }
}