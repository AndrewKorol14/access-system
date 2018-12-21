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
    public partial class SecurityPostForm : Form
    {
        private readonly int _windowHeight = 460;
        private readonly int _windowWidth = 710;

        public BuildingService buildingService;

        public SecurityPostForm(BuildingService buildingService)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximizeBox = false;
            this.buildingService = buildingService;
        }

        private void createCardButton_Click(object sender, EventArgs e)
        {
            CardCreationForm cardCreationForm = new CardCreationForm(buildingService);
            cardCreationForm.Show();
        }

        private void lockCardButton_Click(object sender, EventArgs e)
        {
            LockingCardForm lockingCardForm = new LockingCardForm(buildingService, this);
            lockingCardForm.Show();
            Hide();
        }

        private void emulateEntranceButton_Click(object sender, EventArgs e)
        {
            EmulateEntranceForm emulateEntranceForm = new EmulateEntranceForm();
            emulateEntranceForm.Show();
        }
    }
}
