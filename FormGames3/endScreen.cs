using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Media;
using System.Diagnostics;

namespace FormGames3
{
    public partial class endScreen : Form
    {
        SoundPlayer endTheme = new SoundPlayer(@"../../Resources/The_Christmas_Song_Chestnuts_Roasting_on_an_Open_Fire_-_Slow_Solo_Piano_Jazz-ZtBnp5YOO2o.wav");
        Stopwatch watch = new Stopwatch();
        int score = 0;
        public endScreen(int i)
        {
            InitializeComponent();
            score = i;
            //SoundPlayer song1 = new SoundPlayer(path);
            endTheme.Play();
            watch.Start();
            //serialPort1.Open();

            /*
            if (serialPort1.Read == )
            {
                Form1 gameScreen = new Form1();
                gameScreen.Show();
            }

            if (serialPort1.ReadLine() == )
            {
                help helpScreen = new help();
                helpScreen.Show();
            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (watch.Elapsed.TotalMilliseconds >= 3000)
            {
                label1.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 7000)
            {
                label2.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 10000)
            {
                label3.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 14000)
            {
                label4.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 19000)
            {
                label5.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 22000)
            {
                label6.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 25000)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label1.Text = "Ornaments Collected: " + score;
                label1.Visible = true;   

            } 

            if (score == 10 && watch.Elapsed.TotalMilliseconds >= 27000)
            {
                label2.Text = "You collected all the ornaments!";
                label2.Visible = true;
            }

            if (score == 10 && watch.Elapsed.TotalMilliseconds >= 29000)
            {
                label3.Text = "Just like everyone else probably.";
                label3.Visible = true;
            }

            if (score == 10 && watch.Elapsed.TotalMilliseconds >= 30000)
            {
                label4.Text = "So you get nothing.";
                label4.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 33000)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                //label8.Visible = false;
                label7.Visible = true;
            }
            if (watch.Elapsed.TotalMilliseconds >= 36000)
            {
                this.Close();
                //Application.Restart();
            }


        }
        /*
private void startGame(object sender, EventArgs e)
{
menuTheme.Stop();
Form1 gameScreen = new Form1();
gameScreen.Show();
}

private void showInstructions(object sender, EventArgs e)
{
help helpScreen = new help();
helpScreen.Show();
}
*/
    }
}
