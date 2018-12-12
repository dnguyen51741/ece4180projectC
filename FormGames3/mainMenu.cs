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
using System.Diagnostics;
using System.Media;
using System.Threading;

namespace FormGames3
{
    public partial class mainMenu : Form
    {
        SoundPlayer menuTheme = new SoundPlayer(@"../../Resources/Jingle Bells (Instrumental).wav");
        // SoundPlayer menuTheme = new SoundPlayer(@"../../Resources/The_Christmas_Song_Chestnuts_Roasting_on_an_Open_Fire_-_Slow_Solo_Piano_Jazz-ZtBnp5YOO2o.wav");
        Stopwatch watch = new Stopwatch();
        bool gameOn = false;
        public mainMenu()
        {
            InitializeComponent();
            serialPort1.Open();
            serialPort2.Open();
            //SoundPlayer song1 = new SoundPlayer(path);
            menuTheme.Play();
            watch.Start();

            
        }

        private void startGame(object sender, EventArgs e)
        {
            //menuTheme.Stop();
            startScreen gameScreen = new startScreen();
            gameScreen.Show();
            serialPort1.Close();
            serialPort2.Close();
        }

        private void showInstructions(object sender, EventArgs e)
        {
            help helpScreen = new help();
            helpScreen.Show();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //  && watch.Elapsed.TotalMilliseconds >= 500

            //while (serialPort1.IsOpen) {
            
            try {
                int act = serialPort1.ReadChar();
                if (act.Equals('w') && watch.Elapsed.TotalMilliseconds >= 500)
                {
                    startScreen gameScreen = new startScreen();
                    gameScreen.Show();
                    //gameOn = true;
                    watch.Restart();
                    //gameTimer.Stop();
                    //this.Close();
                    
                    serialPort1.Close();
                    serialPort2.Close();
                } else if (act.Equals('x') && watch.Elapsed.TotalMilliseconds >= 500) {
                    help helpScreen = new help();
                    helpScreen.Show();
                    watch.Restart();
                }
                //Thread.Sleep(500);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
