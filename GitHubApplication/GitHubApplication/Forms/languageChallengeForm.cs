using GitHubApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MaterialSkin;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using GitHubApplication.API;

namespace GitHubApplication.Forms
{
    public partial class LanguageChallengform : MaterialForm
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

            LanguageChallangePanell.Controls.Add(languagesChallengecontrol);


            //  LanguagesChallengecontrol repcontrol = new LanguagesChallengecontrol();
            //showstarsresult.Controls.Add(repcontrol);
        }
    }
}
