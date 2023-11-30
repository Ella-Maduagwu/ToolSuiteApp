using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;

namespace toolsuiteapp.View
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchstring = searchTxtBox.Text;
            SearchController searchController = new SearchController();
            searchController.PerformSearch(searchstring);
        }

        private void HomepageForm_Load(object sender, EventArgs e)
        {

        }

        private void wealthMLabel_Click(object sender, EventArgs e)
        {
            WealthMAnagementForm wealth = new WealthMAnagementForm();
            wealth.ShowDialog();
            this.Close();
        }
        private void BusinessManagLabel_Click(object sender, EventArgs e)
        {
            // same for business management 


        }
        private void adoitPicBox_Click(object sender, EventArgs e)
        {
            // anywhere you see picBox, check the name in front, it is the name of the software 
            // therefore open the page for that software, the one that has add to wishlist or edit 
            // please do it with the admin in mind 
        }

        private void adonisPicBox_Click(object sender, EventArgs e)
        {
            // this is same as above 
        }

        private void finbournePicBox_Click(object sender, EventArgs e)
        {
            //this is same as above 
        }

        private void dataManagLabel_Click(object sender, EventArgs e)
        {
            // this is to open the datamanagement thing 
        }

        private void liminaPicBox_Click(object sender, EventArgs e)
        {
            // open wealth management here 
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // ignore this one 
        }

        private void coherentPicBox_Click(object sender, EventArgs e)
        {

        }

        private void appianPicBox_Click(object sender, EventArgs e)
        {

        }

        private void watsonPicBox_Click(object sender, EventArgs e)
        {

        }

        private void ezopsPicBox_Click(object sender, EventArgs e)
        {

        }

        private void addeparPictBox_Click(object sender, EventArgs e)
        {
            AddeparInfoPage addepar = new AddeparInfoPage();
            this.Hide();
            addepar.ShowDialog();
            this.Close();
        }

        private void investmentBanLabel_Click(object sender, EventArgs e)
        {
            // open the page for investment banking here
            // these events are the hyperlink thing on the homepage 
        }

        private void assetManaLabel_Click(object sender, EventArgs e)
        {
            // same 
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            // open the Software Categories form here 
            SoftwareCategoriesForm softwareCategories = new SoftwareCategoriesForm();
            softwareCategories.ShowDialog();
            this.Close();
        }
    }
}
