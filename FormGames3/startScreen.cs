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
    public partial class startScreen : Form
    {
        //SoundPlayer endTheme;
        Stopwatch watch = new Stopwatch();
        int score = 0;
        public startScreen()
        {
            InitializeComponent();
            //SoundPlayer song1 = new SoundPlayer(path);
            //endTheme.Play();
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
                label7.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 5000)
            {
                label7.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }

            if (watch.Elapsed.TotalMilliseconds >= 18000)
            {
                //endTheme.Stop();
                Form1 gameScreen = new Form1();
                gameScreen.Show();
                this.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
