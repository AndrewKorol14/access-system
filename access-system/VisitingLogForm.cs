using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_system
{
    public partial class VisitingLogForm : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;
        private readonly int backButtonWidth = 100;
        private readonly int backButtonHeight = 30;

        public SecurityPostForm spf;

        private Button backButton;

        public BuildingService buildingService;

        public VisitingLogForm(SecurityPostForm spf, BuildingService buildingService)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.spf = spf;

            this.buildingService = buildingService;
            List<string> logs = buildingService.GetVisitingLogs();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < logs.Count; i++)
            {
                str.Append(logs[i]);
                str.Append('\n');
            }
            visitingLogLabel.Text = str.ToString();

            backButton = new Button();
            backButton.Width = backButtonWidth;
            backButton.Height = backButtonHeight;
            backButton.BackColor = Color.Salmon;
            backButton.Left = 500;
            backButton.Top = visitingLogLabel.Top + visitingLogLabel.Height + 50;
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            this.Controls.Add(backButton);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            spf.Show();
            Close();
        }

        private void VisitingLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            spf.Show();
        }
    }
}
