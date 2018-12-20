using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class StartForm : Form
    {
        private readonly int _windowHeight = 460;
        private readonly int _windowWidth = 710;

        public StartForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximizeBox = false;
        } 

        private void openBuildingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON(*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
            }
        }

        private void newBuildingButton_Click(object sender, EventArgs e)
        {
            NewBuildingCreationForm newBuildingCreationForm = new NewBuildingCreationForm();
            newBuildingCreationForm.Show();
            Hide();
        }
    }
}