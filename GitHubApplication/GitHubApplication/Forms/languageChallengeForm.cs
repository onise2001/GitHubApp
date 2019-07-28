using GitHubApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.API;

namespace GitHubApplication.Forms
{
    public partial class LanguageChallengform : Form
    {

        public LanguageChallengform()
        {
            InitializeComponent();
        }


        private void LanguageChalleng(object sender, PaintEventArgs e)
        {

        }

        private void ChallengPanel_Paint(object sender, PaintEventArgs e)
        {

            LanguageChallangeControl languagesChallengecontrol = new LanguageChallangeControl(new HttpApiClient());
         
            LanguageChalengPanel.Controls.Add(languagesChallengecontrol);


        }
    }
}
