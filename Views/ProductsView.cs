using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductsView : Form , IProductsView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;

        

        public string ProductsId 
        { get { return TxtProductsid.Text; }
            set { TxtProductsid.Text = value;} 
        }
        public string ProductsName 
        {
            get { return TxtProductsName.Text; }
            set { TxtProductsName.Text = value; }
        }
        public string ProductsPrice
        {
            get { return TxtProductsPrice.Text; }
            set { TxtProductsPrice.Text = value; }
        }
        public string ProductsStock 
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }
       
        
        public string SearchValue 
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
      
        public bool IsEdit 
        { 
            get { return isEdit;}
            set { isEdit = value;}
        }
        public bool IsSuccesful 
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductsListBildingSource(BindingSource productsList)
        {
            DgProducts.DataSource = productsList;
        }

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductsDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (SearchEvent != null)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {


                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Add New  Product Mode ";

            };


            BtnEdit.Click += delegate
            {

                EditEvent?.Invoke(this, EventArgs.Empty);


                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Edit Product ";//Cambia el titulo de la pestaña


            };

            BtnDelete.Click += delegate
            {

                var result = MessageBox.Show(
                    "Are you sure you want to delete the select Pay Mode",
                    "Warring",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {

                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPageProductsDetail);
                    tabControl1.TabPages.Add(tabPageProductsList);

                }
                MessageBox.Show(Message);

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsDetail);
                tabControl1.TabPages.Add(tabPageProductsList);


            };

        }



        private static ProductsView instance;
        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }

            return instance;
        }
    }
        
    }

