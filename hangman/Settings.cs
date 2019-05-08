using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            switch (Globals.language)
            {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            Parent.Controls.Add(mainmenu);
            Parent.Controls.Remove(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Globals.language = 0;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Globals.language = 1;
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                Globals.language = 2;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }
    }
}
