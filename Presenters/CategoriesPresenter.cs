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
        private ICategoriesView View;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();
            View = view;
            this.repository = repository;

            this.View.SearchEvent += SearchCategories;
            this.View.AddNewEvent += AddNewCategories;
            this.View.EditEvent += LoadSelectCategoriesToEdit;
            this.View.DeleteEvent += DeleteSelectedCategories;
            this.View.SaveEvent += SaveCategories;
            this.View.CancelEvent += CancelCategories;

            this.View.SetPayModeListBildingSource(categoriesBindingSource);

            LoadAllCategoriesList();
            this.View.Show();
        }

        private void LoadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.View.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValues(this.View.SearchValue);

            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource =  categoriesList;
        }
    }
}
