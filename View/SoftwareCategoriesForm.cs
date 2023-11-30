using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Model;

namespace toolsuiteapp.View
{
    public partial class SoftwareCategoriesForm : Form
    {
        public SoftwareCategoriesForm()
        {
            InitializeComponent();
        }

        public void SetDataSource(BindingList<SoftwareCategoriesModel> categories)
        {
            dataGridViewSoftwareCategories.DataSource = categories;
        }
    }
}
