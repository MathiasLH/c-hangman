using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            Parent.Controls.Add(game);
            Parent.Controls.Remove(this);
        }

        private void char_button_Click(object sender, EventArgs e)
        {
            CharacterSelector charSel = new CharacterSelector();
            Parent.Controls.Add(charSel);
            Parent.Controls.Remove(this);
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            Parent.Controls.Add(settings);
            Parent.Controls.Remove(this);
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
