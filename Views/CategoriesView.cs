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
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;
      

        public string CategoriesId 
        { get { return TxtCategoriesId.Text; } 
          set { TxtCategoriesId.Text = value;}
        }
        public string CategoriesName
        { get { return TxtCategoriesName.Text;}
          set { TxtCategoriesName.Text = value;} 
        }
        public string CategoriesDescription 
        { get { return TxtCategoriesDescription.Text;}
          set { TxtCategoriesDescription.Text = value;}
        }
        public string SearchValue 
        {
          get { return TxtSearch.Text; }
          set { TxtSearch.Text = value;}
        }
        public bool IsEdit
        { get { return isEdit; }
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

        public void SetPayModeListBildingSource(BindingSource categoriesList)
        {
            DgPayMode.DataSource = categoriesList;
        }
        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCategoriesDetail);
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

            //Agregar, llame el evento AddNewEvent cuando se haga click en el boton Btnew
            BtnNew.Click += delegate
            {


                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Add New  Apy Mode ";

            };


            BtnEdit.Click += delegate
            {

                EditEvent?.Invoke(this, EventArgs.Empty);


                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                tabPageCategoriesDetail.Text = "Edit Pay Mode";//Cambia el titulo de la pestaña


            };

            BtnDelet.Click += delegate
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
                    tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                    tabControl1.TabPages.Add(tabPageCategoriesList);

                }
                MessageBox.Show(Message);

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                tabControl1.TabPages.Add(tabPageCategoriesList);


            };

        }



        private static PayModeView instance;
        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

