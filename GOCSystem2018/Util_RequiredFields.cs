using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOCSystem2018
{
    class Util_RequiredFields
    {
        public int readyToSave;

        public void ValidateCombobox(ComboBox one)
        {
            ComboBox[] newTextBox = { one };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if (newTextBox[inti].Text == string.Empty)
                {
                    MessageBox.Show("Please fill the required drop down list");
                    newTextBox[inti].Focus();
                    return;
                }
                readyToSave = 1;
            }
        }
        public void ValidateCombobox1(TextBox one, TextBox two)
        {
            TextBox[] newTextBox = { one, two };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if (newTextBox[inti].Text == string.Empty)
                {
                    MessageBox.Show("Please fill the required drop down list");
                    newTextBox[inti].Focus();
                    readyToSave = 0;
                    return;
                }
                readyToSave = 1;
            }
        }

        public void ValidateTextBox2(TextBox one, TextBox two)
        {
            TextBox[] newTextBox = { one, two };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if (newTextBox[inti].Text == string.Empty)
                {
                    MessageBox.Show("Please fill the required Text");
                    newTextBox[inti].Focus();

                    readyToSave = 0;
                    return;
                }
                readyToSave = 1;
            }
        }


    }
}
