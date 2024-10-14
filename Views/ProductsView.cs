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

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductsDetail
                );
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
        }

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
        public string ProductsCategorieId
        {
            get { return TxtProductsCategorie.Text; }
            set { TxtProductsCategorie.Text = value; }
        }
        public string SearchValue 
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        /// <summary>
        ///
        /// </summary>
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
    }
}
