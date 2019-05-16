using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        bool music = true;
        SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
                      
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("trying to play music");
            sound = new SoundPlayer(Properties.Resources.wii);
            
            sound.PlayLooping();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (music == true)
            {
                sound.Stop();
                music = false;
            }
            else
            {
                sound.PlayLooping();
                music = true;
            }
        }
    }
}
