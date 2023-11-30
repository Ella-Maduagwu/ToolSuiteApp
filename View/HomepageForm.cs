using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using toolsuiteapp.Model;

namespace toolsuiteapp.View
{
    public partial class HomepageForm : Form
    {
        // private readonly SoftwareRepository _softwareRepository = new ();
        //private ICollection<Software> _softwareList => _softwareRepository.GetAll();

        // Example until database exists
        private ICollection<Software> _softwareList => GetExampleSoftwareList();

        public HomepageForm()
        {
            InitializeComponent();
        }



        private void HomepageForm_Load(object sender, EventArgs e)
        {
            RenderSoftwareList(_softwareList);
            searchTxtBox.TextChanged += OnSearchQuery;
        }

        private void RenderSoftwareList(ICollection<Software> softwareList)
        {
            var softwareByCategory = softwareList.GroupBy(software => software.Category)
                .ToDictionary(group => group.Key, group => group.ToList());

            softwareContainerLayoutPanel.Controls.Clear();

            foreach (var softwareCategory in softwareByCategory)
            {
                // Each category gets its own row with a category denoting it
                var softwareCategoryLabel = new Label { Text = $"{softwareCategory.Key} >", AutoSize = true };
                // We should remove the hard-coded categories as well though this will do for now
                // Why is everything hard-coded anyways?
                var softwareCategoryLabelClickHandler = typeof(HomepageForm).GetMethod($"{softwareCategory.Key.Replace(" ", "")}Label_Click",  BindingFlags.NonPublic | BindingFlags.Instance);
                softwareCategoryLabel.Click += (s, e) =>
                {
                    var test = $"{softwareCategory.Key.Replace(" ", "")}Label_Click";
                    softwareCategoryLabelClickHandler?.Invoke(this, new object[] { s, e });
                };
                var softwareCategoryPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    AutoSize = true
                };

                var softwareContainerPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.RightToLeft,
                    WrapContents = false,
                    AutoSize = true
                };

                foreach (var software in softwareCategory.Value)
                {
                    var softwarePanel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        FlowDirection = FlowDirection.BottomUp,
                        WrapContents = false,
                        AutoSize = true,
                        Anchor = AnchorStyles.None
                    };

                    var softwareImage = new PictureBox
                    {
                        ImageLocation = software.ImageUrl,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new(200, 150),
                        Anchor = AnchorStyles.None,
                    };
                    var softwareLabel = new Label
                    {
                        Text = software.Name,
                        AutoSize = true,
                        Anchor = AnchorStyles.None
                    };

                    softwareImage.Click += (s, e) =>
                    {
                        var softwareForm = new SoftwareInfoBaseForm(software);
                        softwareForm.ShowDialog();
                    };

                    softwarePanel.Controls.Add(softwareImage);
                    softwarePanel.Controls.Add(softwareLabel);

                    softwareContainerPanel.Controls.Add(softwarePanel);


                    softwareCategoryPanel.Controls.Add(softwareCategoryLabel);
                    softwareCategoryPanel.Controls.Add(softwareContainerPanel);
                    softwareContainerLayoutPanel.Controls.Add(softwareCategoryPanel);
                }
            }
        }

        private void OnSearchQuery(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxtBox.Text))
            {
                RenderSoftwareList(_softwareList);

                return;
            }

            var queriedSoftwareList = _softwareList.Where(
                software => Regex.IsMatch(
                    software.Name, Regex.Escape(searchTxtBox.Text), RegexOptions.IgnoreCase)
                ).ToList();

            RenderSoftwareList(queriedSoftwareList);
        }

        // Make sure to name these properly otherwise
        // The onclick handler wont work
        private void WealthManagementLabel_Click(object sender, EventArgs e)
        {
            WealthMAnagementForm wealth = new WealthMAnagementForm();
            wealth.ShowDialog();
            this.Close();
        }
        private void BusinessManagementLabel_Click(object sender, EventArgs e)
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

        // These are probably incorrect, just an example
        private ICollection<Software> GetExampleSoftwareList() => new List<Software>
        {
            new Software
            {
                Id = 1,
                Name = "Addepar",
                Description = "Investment Banking software",
                Category = "Investment Banking",
                WebsiteUrl = "https://addepar.com",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/addepar.png"
            },
            new Software
            {
                Id = 2,
                Name = "Adogrc",
                Description = "Investment Banking software",
                Category = "Investment Banking",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/Adogrc.png"
            },
            new Software
            {
                Id = 3,
                Name = "Adoit",
                Description = "Wealth Management software",
                Category = "Wealth Management",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/Adoit.png"
            },
            new Software
            {
                Id = 4,
                Name = "Adonis",
                Description = "Wealth Management software",
                Category = "Wealth Management",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/Adonis.png"
            },
            new Software
            {
                Id = 5,
                Name = "Allvue",
                Description = "Data Management software",
                Category = "Data Management",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/Allvue.png"
            },
            new Software
            {
                Id = 6,
                Name = "Althub",
                Description = "Data Management software",
                Category = "Data Management",
                LastReviewed = DateOnly.FromDateTime(DateTime.Now),
                ImageUrl = "./Utilities/althub.png"
            }
        };
    }
}
