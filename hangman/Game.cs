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
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            Parent.Controls.Add(mainmenu);
            Parent.Controls.Remove(this);
        }
    }
}
