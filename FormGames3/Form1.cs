using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace FormGames3
{

    
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        //string[] path = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceNames();
        SoundPlayer song1 = new SoundPlayer(@"../../Resources/Onett Theme Earthbound Music.wav");
        
        bool shoot = false;
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool hasKey = false;
        bool shooting = false;
        bool shooting1 = false;
        bool shooting2 = false;
        bool shooting3 = false;

        bool soundOn = false;

        int initBullX = 0;
        int initBullY = 0;
        int initBullX2 = 0;
        int initBullY2 = 0;
        int initBullX3 = 0;
        int initBullY3 = 0;
        int hp = 3;

        // Enemy Initializations
        int radius = 50;
        int initEne1X = 0;
        int initEne2X = 0;
        int initEne3X = 0;
        int initEne4X = 0;
        bool leftMove1 = true;
        bool leftMove2 = true;
        bool leftMove3 = true;
        bool leftMove4 = true;
        int eSpeed1 = 5;
        int eSpeed2 = 3;
        int eSpeed3 = 4;
        int eSpeed4 = 1;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        int playSpeed = 3;
        int backLeft = 8;

        bool lvlComplete = false;

        public Form1()
        {

            InitializeComponent();
            serialPort1.Open();
            serialPort2.Open();
            initEne1X = enemy.Left;
            initEne2X = enemy2.Left;
            initEne3X = enemy3.Left;
            initEne4X = enemy4.Left;
            song1.Play();
            watch.Start();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {

            try
            {
                int act = serialPort2.ReadChar();

                if (act.Equals('d'))
                {
                    goleft = false;
                    goright = true;
                }
                else if (act.Equals('a'))
                {
                    goright = false;
                    goleft = true;
                }
                else
                {
                    goright = false;
                    goleft = false;
                }
            }

            catch (Exception ex)
            {

            }

            try
            {
                int act2 = serialPort1.ReadChar();
                if (act2.Equals('x'))
                {
                    shoot = true;
                }
                else if (act2.Equals('w'))
                {
                    jumping = true;
                }
                else
                {
                    shoot = false;
                    jumping = false;
                }
            }
            catch (Exception ex)
            {

            }

            if (watch.Elapsed.TotalMilliseconds >= 5000)
            {
                level1_logo.Visible = false;
                watch.Stop();
            }
            player.Top += jumpSpeed;
            
            player.Refresh();

            // Enemies
            //enemy.Top += jumpSpeed;
            enemy.Top = 325;
            enemy.Refresh();

            //enemy2.Top += jumpSpeed;
            enemy2.Top = 325;
            enemy2.Refresh();

            //enemy3.Top += jumpSpeed;
            enemy3.Top = 325;
            enemy3.Refresh();

            enemy4.Top = 325;
            enemy4.Refresh();

            // Enemy 1 Movement
            // Left
            if (enemy.Left > (initEne1X - radius) && (leftMove1 == true))
            {
                enemy.Left -= eSpeed1;

            }
            else
            {
                leftMove1 = false;
                enemy.Left += eSpeed1;
            }

            // Right
            if ((enemy.Left > (initEne1X + radius)) && (leftMove1 == false))
            {
                leftMove1 = true;
            }

            // Enemy 2 Movement
            if (enemy2.Left > (initEne2X - radius) && (leftMove2 == true))
            {
                enemy2.Left -= eSpeed2;

            }
            else
            {
                leftMove2 = false;
                enemy2.Left += eSpeed2;
            }

            if ((enemy2.Left > (initEne2X + radius)) && (leftMove2 == false))
            {
                leftMove2 = true;
            }

            // Enemy 3 Movement
            if (enemy3.Left > (initEne3X - radius) && (leftMove3 == true))
            {
                enemy3.Left -= eSpeed3;

            }
            else
            {
                leftMove3 = false;
                enemy3.Left += eSpeed3;
            }

            if ((enemy3.Left > (initEne3X + radius)) && (leftMove3 == false))
            {
                leftMove3 = true;
            }

            // Enemy 4 Movement
            if (enemy4.Left > (initEne4X - 20) && (leftMove4 == true))
            {
                enemy4.Left -= eSpeed3;

            }
            else
            {
                leftMove4 = false;
                enemy4.Left += eSpeed3;
            }

            if ((enemy4.Left > (initEne4X + 20)) && (leftMove4 == false))
            {
                leftMove4 = true;
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -30;
                force -= 1;
                if (force >= 0)
                {
                    axWindowsMediaPlayer3.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/jump.wav");
                    axWindowsMediaPlayer3.Ctlcontrols.play();
                }

            }
            else
            {
                jumpSpeed = 12;
            }

            if (goleft && player.Left > 100)
            {
                player.Left -= playSpeed;
            }

            if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            if (goright && background.Left > -1353)
            {
                background.Left -= backLeft;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key" || x is PictureBox && x.Tag == "enemy")
                    {
                        x.Left -= backLeft;
                    }
                }
            }

            if (goleft && background.Left < 2)
            {
                background.Left += backLeft;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key" || x is PictureBox && x.Tag == "enemy")
                    {
                        x.Left += backLeft;
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }

                    if (enemy.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        enemy.Top = x.Top - enemy.Height;
                        jumpSpeed = 0;
                    }

                    if (enemy2.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        enemy2.Top = x.Top - enemy2.Height;
                        jumpSpeed = 0;
                    }

                    if (enemy3.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        enemy3.Top = x.Top - enemy3.Height;
                        jumpSpeed = 0;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        axWindowsMediaPlayer4.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/collect.wav");
                        axWindowsMediaPlayer4.Ctlcontrols.play();
                        this.Controls.Remove(x);
                        score++;
                        label1.Text = "Collect: " + score;
                        
                    }
                }

                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {

                        Thread thread1 = new Thread(new ThreadStart(hpThread));
                        thread1.Start();
                    }

                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bullet.Left = 10;
                        bullet.Top = 10;
                        shooting1 = false;
                        shooting = false;
                        axWindowsMediaPlayer1.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/hit.wav");
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                    }

                    if (bullet2.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bullet2.Left = 39;
                        bullet2.Top = 10;
                        shooting2 = false;
                        shooting = false;
                        axWindowsMediaPlayer1.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/hit.wav");
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }

                    if (bullet3.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bullet3.Left = 68;
                        bullet3.Top = 10;
                        shooting3 = false;
                        shooting = false;
                        axWindowsMediaPlayer1.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/hit.wav");
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                }
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {
                door.Image = Properties.Resources.imageedit_1_3837263550__2_;
                axWindowsMediaPlayer5.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/open.wav");
                axWindowsMediaPlayer5.Ctlcontrols.play();
                serialPort1.Close();
                serialPort2.Close();
                Form2 gameScreen = new Form2(score);
                gameScreen.Show();
                this.Close();
                gameTimer.Stop();
               
                

            }

            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                hasKey = true;
            }

            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop();
                //MessageBox.Show("Died");
                //song1.Stop();
                serialPort1.Close();
                serialPort2.Close();
                Application.Restart();
                
            }

            if (shoot)
            {
                //if (shooting != true)
                //{
                shooting = true;
                if (bullet.Left != player.Left && !shooting1) {
                    bullet.Top = player.Top + 25;
                    bullet.Left = player.Left;
                    initBullX = bullet.Left;
                    initBullY = bullet.Top;
                    shooting1 = true;
                    //soundOn = true;
                    axWindowsMediaPlayer2.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/shootSFX.wav");
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                } else if (bullet2.Left != player.Left && !shooting2)
                {
                    bullet2.Top = player.Top + 25;
                    bullet2.Left = player.Left;
                    initBullX2 = bullet2.Left;
                    initBullY2 = bullet2.Top;
                    shooting2 = true;
                    //soundOn = true;
                    axWindowsMediaPlayer2.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/shootSFX.wav");
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                } else if (bullet3.Left != player.Left && !shooting3)
                {
                    bullet3.Top = player.Top + 25;
                    bullet3.Left = player.Left;
                    initBullX3 = bullet3.Left;
                    initBullY3 = bullet3.Top;
                    shooting3 = true;
                    //soundOn = true;
                    axWindowsMediaPlayer2.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/shootSFX.wav");
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }

                shoot = false;
                //} 
            }

            //if (shooting)
            //{
            if (shooting1)
            {
                bullet.Left += 25;

                if (bullet.Left > initBullX + 800)
                {
                    bullet.Left = 10;
                    bullet.Top = 10;
                    shooting1 = false;
                    shooting = false;
                }
            }
            if (shooting2)
            {
                bullet2.Left += 25;

                if (bullet2.Left > initBullX2 + 800)
                {
                    bullet2.Left = 39;
                    bullet2.Top = 10;
                    shooting2 = false;
                    shooting = false;
                }
            }

            if (shooting3)
            {
                bullet3.Left += 25;

                if (bullet3.Left > initBullX3 + 800)
                {
                    bullet3.Left = 68;
                    bullet3.Top = 10;
                    shooting3 = false;
                    shooting = false;
                }
            }

            //}
        }

        private void hpThread()
        {
            if (hp1.Visible != false)
            {
                hp1.Visible = false;
                hp = 2;
            }
            else if (hp2.Visible != false)
            {
                hp2.Visible = false;
                hp = 1;
            }
            else if (hp3.Visible != false)
            {

                hp3.Visible = false;
                hp = 0;
            }
            Thread.Sleep(2000);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up && !jumping)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                shoot = false;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Up && !jumping)
            {
                jumping = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                shoot = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }

}
