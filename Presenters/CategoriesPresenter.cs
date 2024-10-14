using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;


namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter (ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();
           this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelCategories;

            this.view.SetPayModeListBildingSource(categoriesBindingSource);

            LoadAllCategoriesList();
            this.view.Show();
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);

            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }

    
        private void LoadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {
                new Commnon.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categorie edited succesfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categorie added succesfuly";
                }

                view.IsSuccesful = true;
                LoadAllCategoriesList();
                CleanViewFields ();

            }
            catch (Exception ex)
            {
                // Si ocuure una exepcion se configura IsSuccesfuly en false 
                // y a la propiedad Message de la vista se asigna el mensaje de la excepcion
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";

        }

        private void CancelCategories(object? sender, EventArgs e)
        {
           CleanViewFields();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            try 
            {
                var categories = (CategoriesModel)categoriesBindingSource.Current;

                repository.Delete(categories.Id);
                view.IsSuccesful = true;

                view.Message = "Categorie delete succesfuly";
                LoadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful= false;
                view.Message = "An error ocurred, cloud not delete Categorie";
            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            var categories = (CategoriesModel) categoriesBindingSource.Current;


            view.CategoriesId = categories.Id.ToString();
            view.CategoriesName = categories.Name;
            view.CategoriesDescription = categories.Description;


            view.IsEdit = true;
        }

      
    }
}
