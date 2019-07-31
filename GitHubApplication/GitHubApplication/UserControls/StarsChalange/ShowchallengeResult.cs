using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Models;

namespace GitHubApplication.UserControls.StarsChalange
{
      public partial class ShowchallengeResult : UserControl
        {
            LanguageChallangeData _languageChallangeData;

            public ShowchallengeResult(LanguageChallangeData languageChallangeData)
            {
                InitializeComponent();
                _languageChallangeData = languageChallangeData;
            }

            private void ShowchallengeResult_Load(object sender, EventArgs e)
            {

                FirstStar.Text = _languageChallangeData.FirstStarsCount.ToString();
                FirstLanguage.Text = _languageChallangeData.FirstChoosedLanguage;

                SecondStar.Text = _languageChallangeData.SecondStarsCount.ToString();
                SecondLanguage.Text = _languageChallangeData.SecondChoosedLanguage;

            }

            private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }


      }

      

      
    }

