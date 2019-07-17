using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Common
{
    public class TextBoxValidator
    {
        private readonly Color defaultColor;

        public TextBoxValidator(Color defaultColor)
        {
            this.defaultColor = defaultColor;
        }

        public bool ValidateTextBoxes(Dictionary<TextBox, Label> TextBox_Label_Pairs)
        {
            bool isValid = true;
            foreach (var pair in TextBox_Label_Pairs)
            {
                isValid = ValidatePair(pair) && isValid;

            }

            return isValid;
        }

      

        public bool ValidatePair(KeyValuePair<TextBox, Label> pair)
        {
            var textBox = pair.Key;
            var label = pair.Value;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.ForeColor = Color.Maroon;
                return false;
            }
            else
            {
                label.ForeColor = defaultColor;
                return true;
            }
        }
    }
}
