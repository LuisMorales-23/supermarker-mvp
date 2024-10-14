using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);
            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "0";
            view.ProductsStock = "0";
         
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            products.Price = Convert.ToInt32(view.ProductsPrice);
            products.Stock = Convert.ToInt32(view.ProductsStock);
         


            try
            {
                new Commnon.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Product edited succesfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Product added succesfuly";
                }

                view.IsSuccesful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // Si ocuure una exepcion se configura IsSuccesfuly en false 
                // y a la propiedad Message de la vista se asigna el mensaje de la excepcion
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                // se recupera el objeto de la fila seleccionada del dataviewgrid
                var products = (ProductsModel)productsBindingSource.Current;
                // Se invoca el Metodo Delete del repositorio pasandole el ID del Pay Mode

                repository.Delete(products.Id);
                view.IsSuccesful = true;
                view.Message = "Product deleted succesfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, cloud not delete product";

            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductsModel)productsBindingSource.Current;
            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name;
            view.ProductsPrice = products.Price.ToString();
            view.ProductsStock = products.Stock.ToString();
           
            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {

            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }

            productsBindingSource.DataSource = productsList;
        }
       
    }
}
