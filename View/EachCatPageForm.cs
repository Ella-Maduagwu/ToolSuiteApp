using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using toolsuiteapp.Model;

namespace toolsuiteapp.View
{
    public partial class EachCatPageBaseForm : Form
    {

        private UserRepository _userRepository;
        private AddSoftwaresController _addSoftwaresController;


        public EachCatPageBaseForm(string name)
        {
            InitializeComponent();

            _userRepository = new UserRepository();
            LoadSoftwares(name);

        }

        public void LoadSoftwares(string name)
        {
            var Softwares = _userRepository.GetSoftwares(name);
            foreach (var software in Softwares)
            {
                var Logo = _userRepository.GetLogoImage(software.SoftwareName);
                int YOffset = 34;
                int XOffset = 185;
                PictureBox pictureBox = new PictureBox()
                {
                    Image = _addSoftwaresController.ConvertByteArrayToImage(Logo),
                    Location = new Point(34, YOffset),
                    Size = new Size(187, 174)
                };

                Label label = new Label()
                {
                    Text = software.SoftwareName,
                    Location = new Point(277, XOffset),
                    Size = new Size(59, 25)
                };

                YOffset += 351;
                XOffset += 185;

                pictureBox.Click += (sender, e) =>
                {
                    //open software info form 
                };

                CategoryPanel.Controls.Add(pictureBox);
                CategoryPanel.Controls.Add(label);


            }
        }
    }
}