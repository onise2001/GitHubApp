﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace GitHubApplication.Forms
{
    public partial class UserPage : MaterialForm
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Width = MenuPanel.Width == 210 ? 55 : 210;
            MenuButton.Left= MenuPanel.Width == 55 ? 3 : 162;
        }
    }
}
