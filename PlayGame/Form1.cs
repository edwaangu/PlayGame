using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutputText.Hide();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            SoundPlayer tickPlayer = new SoundPlayer(Properties.Resources.Tick);
            SoundPlayer goPlayer = new SoundPlayer(Properties.Resources.Go_Sound);
            PlayButton.Hide();
            OutputText.Show();
            tickPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            OutputText.Text = "Starting in 2...";
            tickPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            OutputText.Text = "Starting in 1...";
            tickPlayer.Play();

            Refresh();
            Thread.Sleep(1000);
            this.BackColor = Color.Green;
            OutputText.Text = "Go!";
            goPlayer.Play();
        }
    }
}
