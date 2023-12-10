using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Data;
using toolsuiteapp.Model;
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class SoftwareInfoBaseForm : Form
    {
        private readonly VendorRepository _vendorRepository = new();
        private readonly Software _software;

        private bool editButtonClicked = false;
        public SoftwareInfoBaseForm(Software software)
        {
            _software = software;

            InitializeComponent();

            if (!string.IsNullOrEmpty(_software.WebsiteUrl))
            {
                websiteLabel.Visible = true;
                websiteLabel.Enabled = true;
            }

            softwareNameLabel.Text = _software.Name;
            softwareImageBox.Image = Image.FromFile(_software.ImageUrl);
            softwareDescriptionTextBox.Text = _software.Description;
            softwareLastReviewedLabel.Text = _software.LastReviewed.ToString();
            softwareLastDemoLabel.Text = _software.LastDemoDate.ToString();

            var vendor = _vendorRepository.Get(_software.Id);

            vendorNameTextBox.Text = vendor.Name;
            vendorDateEstablishedTextBox.Text = vendor.DateEstablished.ToString();
            vendorEmployeeAmountTextBox.Text = vendor.EmployeeAmount.ToString();
            vendorWebsiteUrlTextBox.Text = vendor.WebsiteUrl;
            vendorContactNumbesTextBox.Text = vendor.ContactNumbers;
            vendorLocationListTextBox.Text = vendor.Locations;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            editButtonClicked = true;
        }


        public void websiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                new ProcessStartInfo()
                {
                    FileName = _software.WebsiteUrl,
                    UseShellExecute = true
                }
            );
        }

        // only if user role  == admin, show below method 

        public void websiteLabel_MouseUp(object sender, MouseEventArgs e)
        // this code below make the linkLabel editable
        // it is to be shown only when it the admin permission
        {
            if (e.Button == MouseButtons.Right)// when the linklabel is rightclicked
            {
                TextBox textbox = new TextBox();
                {// create a textbox at the same location as the linklabel and type your changes in it 
                    Size = websiteLabel.Size;
                    Location = websiteLabel.Location;
                    Text = websiteLabel.Text;
                };
                textbox.Leave += (s, e) =>
                {// exits when you click away from the link label
                    websiteLabel.Text = textbox.Text;// then saves the texbox input as new link label text 
                    textbox.Visible = false;
                };
                this.Controls.Add(textbox);
                textbox.BringToFront();
                textbox.Focus();
            }
        }


        private void vendorUpdateButton_Click(object sender, EventArgs e)
        {
            _vendorRepository.Update(
                new()
                {
                    Name = vendorNameTextBox.Text,
                    DateEstablished = DateOnly.Parse(vendorDateEstablishedTextBox.Text),
                    EmployeeAmount = int.Parse(vendorEmployeeAmountTextBox.Text),
                    WebsiteUrl = vendorWebsiteUrlTextBox.Text,
                    ContactNumbers = vendorContactNumbesTextBox.Text,
                    Locations = vendorLocationListTextBox.Text
                }
            );
        }
    }
}
