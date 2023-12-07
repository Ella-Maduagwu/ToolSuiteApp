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
using toolsuiteapp.Data;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class HomepageForm : Form
    {
        private SearchController searchController;
        private UserSession _userSession;
        public HomepageForm( UserSession userSession)
        {
            InitializeComponent();
            _userSession = userSession;
            UserRepository userRepository = new UserRepository();
            searchController = new SearchController(this, userRepository);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text;
            searchController.PerformSearchAndOpenForm(searchTerm);
        }
        private void HomepageForm_Load(object sender, EventArgs e)
        {
            // ignore this one 
        }

        private void WealthMLabel_Click(object sender, EventArgs e)
        {
            WealthMAnagementForm wealth = new();
            this.Hide();
            wealth.ShowDialog();
            this.Close();
        }

        private void AdonisPicBox_Click(object sender, EventArgs e)
        {
            AdonisInfoForm adonis = new();
            this.Hide();
            adonis.ShowDialog();
            this.Close();
        }

        private void FinbournePicBox_Click(object sender, EventArgs e)
        {
            FinbourneInfoForm finbourne = new();
            this.Hide();
            finbourne.ShowDialog();
            this.Close();
        }

        private void DataManagLabel_Click(object sender, EventArgs e)
        {
            DataManagementForm data = new();
            this.Hide();
            data.ShowDialog();
            this.Close();
        }

        private void LiminaPicBox_Click(object sender, EventArgs e)
        {
            LiminaInfoForm limina = new();
            this.Hide();
            limina.ShowDialog();
            this.Close();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            // ignore this one 
        }

        private void CoherentPicBox_Click(object sender, EventArgs e)
        {
            CoherentInfoForm coherent = new();
            this.Hide();
            coherent.ShowDialog();
            this.Close();
        }

        private void AppianPicBox_Click(object sender, EventArgs e)
        {
            AppianInfoForm appian = new();
            this.Hide();
            appian.ShowDialog();
            this.Close();
        }

        private void WatsonPicBox_Click(object sender, EventArgs e)
        {
            WatsonInfoPage watson = new();
            this.Hide();
            watson.ShowDialog();
            this.Close();
        }

        private void EzopsPicBox_Click(object sender, EventArgs e)
        {
            EzopsInfoForm ezops = new();
            this.Hide(); ezops.ShowDialog(); this.Close();
        }

        private void AddeparPictBox_Click(object sender, EventArgs e)
        {
            AddeparInfoPage addepar = new();
            this.Hide();
            addepar.ShowDialog();
            this.Close();
        }

        private void InvestmentBanLabel_Click(object sender, EventArgs e)
        {
            InvestmentBankingForm investment = new();
            this.Hide();
            investment.ShowDialog();
            this.Close();
        }

        private void AssetManaLabel_Click(object sender, EventArgs e)
        {
            AssetManagementForm assetMana = new();
            this.Hide();
            assetMana.ShowDialog();
            this.Close();
        }

        private void SoftwareButton_Click(object sender, EventArgs e)
        {
            // open the Software Categories form here 
            SoftwareCategoriesForm softwareCategories = new(_userSession);
            softwareCategories.ShowDialog();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {// users can open their profile from here 
            ProfileForm form = new ProfileForm();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            VendorForm form = new VendorForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
