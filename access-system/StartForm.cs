﻿using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewBuildingCreationForm newBuildingCreationForm = new NewBuildingCreationForm();
            newBuildingCreationForm.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
