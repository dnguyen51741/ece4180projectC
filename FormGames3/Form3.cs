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
    public partial class Form3 : Form
    {
        Stopwatch watch = new Stopwatch();
        Stopwatch watch2 = new Stopwatch();
        //string[] path = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceNames();
        SoundPlayer song1 = new SoundPlayer(@"../../Resources/The_First_Noel_-_Bing_Crosby-XyuwLem8Ztk.wav");

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
        int initBullX4 = 0;
        int initBullY4 = 0;
        bool eneShoot = false;
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

        int eneHp = 10;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        int playSpeed = 18;
        int backLeft = 8;

        int randValue = 25;

        bool lvlComplete = false;

        public Form3(int i)
        {
            score = i;
            InitializeComponent();
            serialPort1.Open();
            serialPort2.Open();
            label1.Text = "Collect: " + score;
            initEne1X = enemy.Left;
            initEne4X = enemy4.Left;
            song1.Play();       

            watch.Start();
            watch2.Start();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            //door.BackColor = Color.White;

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
                //watch2.Start();
            }
            player.Top += jumpSpeed;
            
            player.Refresh();

            // Enemies
            //enemy.Top += jumpSpeed;
            enemy.Top = 185;
            enemy.Refresh();

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

            // Boss Enemy Shooting
            if (watch2.Elapsed.TotalMilliseconds >= 2000 && eneShoot == false && eneHp > 0)
            {
                axWindowsMediaPlayer2.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/shootSFX.wav");
                axWindowsMediaPlayer2.Ctlcontrols.play();
                bullet4.Top = player.Top + 10;
                bullet4.Left = enemy.Left;
                initBullX4 = bullet.Left;
                initBullY4 = bullet.Top;
                eneShoot = true;
                
            }

            if (eneShoot)
            {
                bullet4.Left -= 25;
            }

            if (bullet4.Left < initBullX4 - 500)
            {
                bullet4.Left = 930;
                bullet4.Top = 67;
                eneShoot = false;
                watch2.Restart();
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
                    
                    if (enemy4.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                       enemy4.Top = x.Top - enemy4.Height;
                        jumpSpeed = 0;
                    }
                    /*
                    if (enemy3.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        enemy3.Top = x.Top - enemy3.Height;
                        jumpSpeed = 0;
                    } */
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

                if (x is PictureBox && x.Tag == "char")
                {
                    if (bullet4.Bounds.IntersectsWith(x.Bounds))
                    {
                        axWindowsMediaPlayer1.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/hit.wav");
                        axWindowsMediaPlayer1.Ctlcontrols.play();
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
                        if (x.Name == "enemy")
                        {
                            axWindowsMediaPlayer5.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/bossDefeat.wav");
                            if (eneHp == 0)
                            {
                                axWindowsMediaPlayer5.Ctlcontrols.play();
                                this.Controls.Remove(x);
                                this.Controls.Remove(bullet4);

                            } else {
                                eneHp -= 1;
                                label2.Text = "Oreo Candy Cane King's Health: " + eneHp;
                                axWindowsMediaPlayer1.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/hit.wav");
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                        } else if (x.Name != "enemy"){
                            this.Controls.Remove(x);
                        }
                        
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
                //song1.Stop();
                //MessageBox.Show("Complete");
                axWindowsMediaPlayer5.URL = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources/open.wav");
                axWindowsMediaPlayer5.Ctlcontrols.play();
                song1.Stop();
                serialPort2.Close();
                serialPort1.Close();
                
                endScreen gameScreen = new endScreen(score);
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
                song1.Stop();
                serialPort2.Close();
                serialPort1.Close();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

}
