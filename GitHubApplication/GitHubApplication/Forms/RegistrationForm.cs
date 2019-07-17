using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
    public partial class RegistrationForm : Form
    {
        Dictionary<TextBox, Label> TextBoxLabelPairs;


        public RegistrationForm()
        {
            InitializeComponent();

            TextBoxLabelPairs = new Dictionary<TextBox, Label>
            {
                [firstNameTextBox] = firstNameLabel,
                [lastNameTextBox] = lastNameLabel,
                [emailTextBox] = emailLabel,
                [userNameTextBox] = userNameLabel,
                [passwordTextBox] = passwordLabel,

            };
        }


        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
