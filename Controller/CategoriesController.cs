using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Data;
using toolsuiteapp.Model;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{
    public  class CategoriesController
    {
        private SoftwareCategoriesForm view;// initialization
        private UserRepository userRepository;
        public CategoriesController(SoftwareCategoriesForm view, UserRepository userRepository)
        {
            this.view = view;
            this.userRepository = userRepository;

            LoadCategories();// fetches software categories through UserRepository 
        }

        public void LoadCategories()
        {
            var categories = userRepository.GetSoftwareCategories();
            // Pass the categories to the view to display in the DataGridView
            // Convert the list to a BindingList for data binding purposes
            view.SetDataSource(new BindingList<SoftwareCategoriesModel>(categories));// allows DataGridView to automatically update whenever the underlyin data changes
        }

        public void SaveCategories(SoftwareCategoriesModel category)
        {
            userRepository.AddCategory(category);
            LoadCategories();// refresh the list 
        }

        public void DeleteCategory(SoftwareCategoriesModel category)
        {
            userRepository.DeleteCategory(category);
            LoadCategories();// refresh the list
        }

    }
}
