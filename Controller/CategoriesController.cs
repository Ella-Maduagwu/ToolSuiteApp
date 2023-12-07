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
      
        private UserRepository _userRepository;
        public CategoriesController( UserRepository userRepository)
        {
            this._userRepository = userRepository;

           
        }

        public void SaveCategories(SoftwareCategoriesModel category)
        {
            if (category.Id > 0)
            {
                _userRepository.UpdateCategory(category);// updates a
            }
            else
            {
                _userRepository.AddCategory(category);// adds new category to the db
               
            }
            

        }

        public void DeleteCategory(SoftwareCategoriesModel category)
        {
            _userRepository.DeleteCategory(category);
            
        }

    }
}
