using access_system.IServices;
using Repositories;
using Services;
using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class StartForm : Form
    {
        private readonly int _windowHeight = 460;
        private readonly int _windowWidth = 710;

        public JsonBuildingRepositore jbr;
        public IBuildingServic buildingService;

        public StartForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximizeBox = false;
            jbr = new JsonBuildingRepositore();
            buildingService = new BuildingService(jbr);
        } 

        private void openBuildingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON(*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                buildingService.GetBuilding(ofd.FileName);
                Building buildingForm = new Building(((BuildingService)buildingService).buildingEntity, (BuildingService)buildingService);
                SecurityPostForm spf = new SecurityPostForm((BuildingService)buildingService);
                spf.Show();
                buildingForm.Show();
                Hide(); 
            }
        }

        private void newBuildingButton_Click(object sender, EventArgs e)
        {
            NewBuildingCreationForm newBuildingCreationForm = new NewBuildingCreationForm((BuildingService)buildingService);
            newBuildingCreationForm.Show();
            Hide();
        }
    }
}