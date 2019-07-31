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

namespace GitHubApplication.UserControls
{
    public partial class ShowchallengeResult : UserControl
    {
        GitHubRepository gitHubRepository;
        LanguageChallangeData _languageChallangeData;
        public ShowchallengeResult(LanguageChallangeData languageChallangeData)
        {
            InitializeComponent();
            _languageChallangeData=languageChallangeData;
        }

        private void ShowchallengeResult_Load(object sender, EventArgs e)
        {
            Stars.Text = _languageChallangeData.StarsCount.ToString();
            Language.Text = _languageChallangeData.ChoosedLanguage;
               

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Language_Click(object sender, EventArgs e)
        {
            
        }
    }
}
