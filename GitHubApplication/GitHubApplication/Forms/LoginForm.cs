﻿using GitHubApplication.Common;
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
using Unity;



namespace GitHubApplication.Forms
{
    public partial class LoginForm : Form
    {
        TextBoxValidator validator;
        IUserService userService;
        Dictionary<TextBox, Label> TextBoxLabelPairs;

        public event EventHandler<User> SuccessfulLogin;



        public LoginForm(IUserService service)
        {
            InitializeComponent();
            validator = new TextBoxValidator(loginLabel.ForeColor);
            userService = service;
            TextBoxLabelPairs = new Dictionary<TextBox, Label>()
            {
                [loginTextBox] = loginLabel,
                [passwordTextBox] = passwordLabel,

            };

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (validator.ValidateTextBoxes(TextBoxLabelPairs))
            {
                Login(loginTextBox.Text, passwordTextBox.Text);
            }

        }




        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var pair = TextBoxLabelPairs.FirstOrDefault(p => p.Key.Equals(sender));
            validator.ValidatePair(pair);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = ServiceManager.Instance.Container.Resolve<RegistrationForm>();
            registrationForm.SuccessfulRegistration += OnSuccessfullRegistration;
            registrationForm.ShowDialog();
        }

        private void OnSuccessfullRegistration(object sender, User user)
        {
            Login(user.Email, user.Password);

            if (sender is RegistrationForm registrationForm)
            {
                registrationForm.SuccessfulRegistration -= OnSuccessfullRegistration;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var regForm = ServiceManager.Instance.Container.Resolve<RegistrationForm>();
            regForm.SuccessfulRegistration += OnSuccessfullRegistration;
            regForm.ShowDialog();

        }

        private void Login(string login, string password)
        {
            var result = userService.Login(login, password);
            if (result != null)
            {
                SuccessfulLogin?.Invoke(this, result);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                loginErrorLabel.Visible = true;
            }
        }


    }
}
