using GitHubApplication.Common;
using GitHubApplication.Models;
using GitHubApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MaterialSkin.Controls;

namespace GitHubApplication.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        IUserService userService;

        Dictionary<TextBox, Label> TextBoxLabelPairs;
        TextBoxValidator validator;
        public event EventHandler<User> SuccessfulRegistration;
        IPasswordHasher hasher;


        public RegistrationForm(IUserService service , IPasswordHasher passwordHasher)
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

            validator = new TextBoxValidator(firstNameLabel.ForeColor);
            userService = service;
            hasher = passwordHasher;
        }


        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (validator.ValidateTextBoxes(TextBoxLabelPairs) & CheckPasswordMatch())
            {
                var newUser = new User
                {
                    Email = emailTextBox.Text,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Password = hasher.HashWithSalt(repeatePasswordTextBox.Text),
                    UserName = userNameTextBox.Text,
                };

                Register(newUser);
            }

        }

        private void Register(User user)
        {
            var result = userService.Register(user);
            if (result != null)
            {
                SuccessfulRegistration?.Invoke(this, result);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                userNameErrorLabel.Visible = true;
            }
        }


        bool CheckPasswordMatch()
        {
            bool match = passwordTextBox.Text == repeatePasswordTextBox.Text;
            passwordErrorLabel.Visible = !match;
            return match;
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var pair = TextBoxLabelPairs.FirstOrDefault(p => p.Key.Equals(sender));
            validator.ValidatePair(pair);
        }


    }
}
