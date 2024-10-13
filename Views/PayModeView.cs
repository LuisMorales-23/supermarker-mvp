﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {

        private bool isEdit;
        private bool isSuccesful;
        private string message;


        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
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

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl2.TabPages.Remove(tabPagePayModeDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Asocia el evento Click del botón BtnSearch a un delegado anónimo
            // que invoca el evento SearchEvent
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

                tabControl2.TabPages.Remove(tabPagePayModeList);
                tabControl2.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New  Apy Mode ";

            };


            BtnEdit.Click += delegate
            {

                EditEvent?.Invoke(this, EventArgs.Empty);


                tabControl2.TabPages.Remove(tabPagePayModeList);
                tabControl2.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode";//Cambia el titulo de la pestaña


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
                    tabControl2.TabPages.Remove(tabPagePayModeDetail);
                    tabControl2.TabPages.Add(tabPagePayModeList);

                }
                MessageBox.Show(Message);

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl2.TabPages.Remove(tabPagePayModeDetail);
                tabControl2.TabPages.Add(tabPagePayModeList);


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
    }


}
