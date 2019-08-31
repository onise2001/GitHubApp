using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.API;
using GitHubApplication.Models;
using GitHubApplication.UserControls.StarsChalange;
using GitHubApplication.Common;

namespace GitHubApplication.UserControls
{
    public partial class LanguageChallangeControl : UserControl
    {
       public enum CircleColors
        {
            Default, Green, DarkOrange, Coffe, Red,  Blue,Pink
        }

        GitHubAppDbContext dataBase;
        LanguageStatistics languagestatistics = new LanguageStatistics();
        public bool Indicator { get; set; } = true;
        LanguageChallangeData languageChallangeData=new LanguageChallangeData();
        HttpApiClient Client;

        public LanguageChallangeControl(HttpApiClient apiClient)
        {
             
            InitializeComponent();
            Client = apiClient;

        }


        private async void Compare_Click(object sender, EventArgs e)
        {

            Compare.Enabled = false;

            try
            {
                var Firstresponse = await Client.GetTrendingRepositories(languageChallangeData.FirstChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)).ToString("yyyy-MM-dd"));
                var Secondresponse = await Client.GetTrendingRepositories(languageChallangeData.SecondChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0, 0)).ToString("yyyy-MM-dd"));


                if (Firstresponse != null && Secondresponse != null)
                {
                   

                    var firstresult = Firstresponse.items.Select(r => r.stargazers_count);

                    languageChallangeData.FirstStarsCount = firstresult.Aggregate((Result, Item) => Result + Item);

                    var secondresult = Secondresponse.items.Select(r => r.stargazers_count);
                    languageChallangeData.SecondStarsCount = secondresult.Aggregate((Result, Item) => Result + Item);

                    Winner_Label.Enabled = true;

                    Winner_Label.Text+= languageChallangeData.FirstStarsCount > languageChallangeData.SecondStarsCount ?
                         languageChallangeData.FirstChoosedLanguage : languageChallangeData.SecondChoosedLanguage;
                    var Winner = languageChallangeData.FirstStarsCount > languageChallangeData.SecondStarsCount ?
                         languageChallangeData.FirstChoosedLanguage : languageChallangeData.SecondChoosedLanguage;
                    var WinnerScore = languageChallangeData.FirstStarsCount > languageChallangeData.SecondStarsCount ?
                         languageChallangeData.FirstStarsCount: languageChallangeData.FirstStarsCount;

                    languagestatistics.StarsCaunt = WinnerScore;
                    languagestatistics.Language = Winner;

                    languagestatistics.Date = DateTime.Now;
                    dataBase.StarsStatistics.Add(languagestatistics);
                    dataBase.SaveChanges();
                    


                    ShowchallengeResult repoControls = new ShowchallengeResult(languageChallangeData);
                    ChalangeResultPanel.Controls.Add(repoControls);
                    NewChallange.Enabled = true;
                    Winner_Label.Visible = true;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void Java_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                ScondLanguage_label.Text = "Java";
                languageChallangeData.SecondChoosedLanguage = "Java";
                Java.Enabled = false;
                Compare.Enabled = true;
                SecondLanguageCircle.ImageIndex = (int)CircleColors.DarkOrange;

            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                FirstLanguage_label.Text = "Java";
                languageChallangeData.FirstChoosedLanguage = "Java";
                Java.Enabled = false;
                FirstLanguageCircle.ImageIndex = (int)CircleColors.DarkOrange;

            }

        }

        private void Ruby_Click(object sender, EventArgs e)
        {


            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                SecondLanguageCircle.ImageIndex = (int)CircleColors.Red;
                ScondLanguage_label.Text = "ruby";
                languageChallangeData.SecondChoosedLanguage = "ruby";
                Ruby.Enabled = false;
                Compare.Enabled = true;
            }

            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                FirstLanguageCircle.ImageIndex = (int)CircleColors.Red;
                FirstLanguage_label.Text = "ruby";
                languageChallangeData.FirstChoosedLanguage = "ruby";
                Ruby.Enabled = false;
            }
           
        }


        private void C_Click(object sender, EventArgs e)
        {

            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                SecondLanguageCircle.ImageIndex = (int)CircleColors.Pink;
                languageChallangeData.SecondChoosedLanguage = "C";
                ScondLanguage_label.Text = "C++";
                C.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                FirstLanguageCircle.ImageIndex = (int)CircleColors.Pink;
                languageChallangeData.FirstChoosedLanguage = "C";
                FirstLanguage_label.Text = "C++";
                C.Enabled = false;
            }
        }

        private void C_Sharp_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {

                languageChallangeData.SecondChoosedLanguage = ".NET";
                ScondLanguage_label.Text = "C#";
                C_Sharp.Enabled = false;
                Compare.Enabled = true;
                SecondLanguageCircle.ImageIndex = (int)CircleColors.Green;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = ".NET";
                FirstLanguage_label.Text = "C#";
                
                C_Sharp.Enabled = false;
                FirstLanguageCircle.ImageIndex = (int)CircleColors.Green;

            }
        }

        private void NewChallange_Click(object sender, EventArgs e)
        {
            languageChallangeData.FirstChoosedLanguage = null;
            languageChallangeData.SecondChoosedLanguage = null;

            FirstLanguageCircle.ImageIndex = (int)CircleColors.Default;
            SecondLanguageCircle.ImageIndex = (int)CircleColors.Default;
            ChalangeResultPanel.Controls.Clear();
            C_Sharp.Enabled = true;
            C.Enabled = true;
            Java.Enabled = true;
            Ruby.Enabled = true;
            Compare.Enabled = false;
            ScondLanguage_label.Text = null;
            FirstLanguage_label.Text = null;
            Winner_Label.Text =" Winner is ";
        }

        private void Python_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                SecondLanguageCircle.ImageIndex = (int)CircleColors.Blue;
                languageChallangeData.SecondChoosedLanguage = "Python";
                ScondLanguage_label.Text = "Python";
                Python.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                FirstLanguageCircle.ImageIndex = (int)CircleColors.Blue;
                FirstLanguage_label.Text = "Python";
                languageChallangeData.FirstChoosedLanguage = "Python";
                Python.Enabled = false;
            }

        }

        

        private void Assembly_Click(object sender, EventArgs e)
        {

            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                SecondLanguageCircle.ImageIndex = (int)CircleColors.Coffe;
                languageChallangeData.SecondChoosedLanguage = "Assembly";
                ScondLanguage_label.Text = "Assembly";
                Python.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                FirstLanguageCircle.ImageIndex = (int)CircleColors.Coffe;
                FirstLanguage_label.Text = "Assembly";
                languageChallangeData.FirstChoosedLanguage = "Assembly";
                Python.Enabled = false;
            }



        }

        private void LanguageChallangeControl_Load(object sender, EventArgs e)
        {

        }
    }
    }
