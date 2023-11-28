using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class SoftwareInfoBaseForm : Form
    {
        private bool editButtonClicked = false;

        public SoftwareInfoBaseForm()
        {
            InitializeComponent();
            EditButton.Visible = false; 
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            editButtonClicked = true;
        }

        private void screenPicBox1_Click(object sender, EventArgs e)
        {
            UserSession userSession = new UserSession();
            string currentUserRole = userSession.GetRole();

            if (currentUserRole == "Admin")
            {
                EditButton.Visible = true;

                if (editButtonClicked)
                {
                    EditImage();
                }
            }
            else
            {
                MessageBox.Show(Text, "Add to Wishlist?");
            }
        }

        private void EditImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                screenPicBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        public void WebsiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            websiteLabel.Text = "Visit website";
            websiteLabel.Links.Add(0, 12, "https://google.com"); //need to 
            string url = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(url);
        }

        public void WebsiteLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MakeLinkLabelEditable();
            }
        }

        private void MakeLinkLabelEditable()
        {
            TextBox editableTextbox = new TextBox
            {
                Size = websiteLabel.Size,
                Location = websiteLabel.Location,
                Text = websiteLabel.Text
            };

            editableTextbox.Leave += (s, e) =>
            {
                websiteLabel.Text = editableTextbox.Text;
                editableTextbox.Visible = false;
            };

            this.Controls.Add(editableTextbox);
            editableTextbox.BringToFront();
            editableTextbox.Focus();
        }
    }
}