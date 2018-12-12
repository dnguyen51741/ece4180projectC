namespace FormGames3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer5 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.level1_logo = new System.Windows.Forms.PictureBox();
            this.hp1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.hp3 = new System.Windows.Forms.PictureBox();
            this.hp2 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 491);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 27;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(81, 491);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer2.TabIndex = 28;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(162, 491);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer3.TabIndex = 36;
            this.axWindowsMediaPlayer3.Visible = false;
            // 
            // axWindowsMediaPlayer4
            // 
            this.axWindowsMediaPlayer4.Enabled = true;
            this.axWindowsMediaPlayer4.Location = new System.Drawing.Point(243, 491);
            this.axWindowsMediaPlayer4.Name = "axWindowsMediaPlayer4";
            this.axWindowsMediaPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer4.OcxState")));
            this.axWindowsMediaPlayer4.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer4.TabIndex = 37;
            this.axWindowsMediaPlayer4.Visible = false;
            // 
            // axWindowsMediaPlayer5
            // 
            this.axWindowsMediaPlayer5.Enabled = true;
            this.axWindowsMediaPlayer5.Location = new System.Drawing.Point(324, 491);
            this.axWindowsMediaPlayer5.Name = "axWindowsMediaPlayer5";
            this.axWindowsMediaPlayer5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer5.OcxState")));
            this.axWindowsMediaPlayer5.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer5.TabIndex = 38;
            this.axWindowsMediaPlayer5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(873, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 39;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox5.Location = new System.Drawing.Point(1089, 187);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox6.Location = new System.Drawing.Point(903, 191);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox7.Location = new System.Drawing.Point(1302, 190);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(53, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::FormGames3.Properties.Resources.christmastiles_2__1_;
            this.pictureBox4.Location = new System.Drawing.Point(935, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(857, 39);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FormGames3.Properties.Resources.christmastiles_2__1_;
            this.pictureBox3.Location = new System.Drawing.Point(608, 276);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(857, 39);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox10.Location = new System.Drawing.Point(1407, 18);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 45);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox9.Location = new System.Drawing.Point(1221, 22);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 41);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "coin";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.White;
            this.door.Image = global::FormGames3.Properties.Resources._1543214269589854__1_;
            this.door.Location = new System.Drawing.Point(1748, 242);
            this.door.Margin = new System.Windows.Forms.Padding(0);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(393, 230);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 3;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.Image = global::FormGames3.Properties.Resources.candycane;
            this.enemy4.Location = new System.Drawing.Point(344, 187);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(70, 71);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 26;
            this.enemy4.TabStop = false;
            this.enemy4.Tag = "enemy";
            // 
            // level1_logo
            // 
            this.level1_logo.BackColor = System.Drawing.Color.Transparent;
            this.level1_logo.Image = global::FormGames3.Properties.Resources.level2_logo;
            this.level1_logo.Location = new System.Drawing.Point(344, 79);
            this.level1_logo.Margin = new System.Windows.Forms.Padding(0);
            this.level1_logo.Name = "level1_logo";
            this.level1_logo.Size = new System.Drawing.Size(302, 62);
            this.level1_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.level1_logo.TabIndex = 21;
            this.level1_logo.TabStop = false;
            this.level1_logo.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // hp1
            // 
            this.hp1.BackColor = System.Drawing.Color.Transparent;
            this.hp1.Image = global::FormGames3.Properties.Resources._2ef286e85b00823;
            this.hp1.Location = new System.Drawing.Point(9, 44);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(20, 19);
            this.hp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp1.TabIndex = 19;
            this.hp1.TabStop = false;
            this.hp1.Tag = "hp";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = global::FormGames3.Properties.Resources.candycane;
            this.enemy3.Location = new System.Drawing.Point(1163, 161);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(66, 71);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 18;
            this.enemy3.TabStop = false;
            this.enemy3.Tag = "enemy";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::FormGames3.Properties.Resources.candycane;
            this.enemy2.Location = new System.Drawing.Point(950, 161);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(70, 71);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 17;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // hp3
            // 
            this.hp3.BackColor = System.Drawing.Color.Transparent;
            this.hp3.Image = global::FormGames3.Properties.Resources._2ef286e85b00823;
            this.hp3.Location = new System.Drawing.Point(61, 44);
            this.hp3.Name = "hp3";
            this.hp3.Size = new System.Drawing.Size(20, 19);
            this.hp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp3.TabIndex = 16;
            this.hp3.TabStop = false;
            this.hp3.Tag = "hp";
            // 
            // hp2
            // 
            this.hp2.BackColor = System.Drawing.Color.Transparent;
            this.hp2.Image = global::FormGames3.Properties.Resources._2ef286e85b00823;
            this.hp2.Location = new System.Drawing.Point(35, 44);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(20, 19);
            this.hp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp2.TabIndex = 15;
            this.hp2.TabStop = false;
            this.hp2.Tag = "hp";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::FormGames3.Properties.Resources.candycane;
            this.enemy.Location = new System.Drawing.Point(723, 172);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(71, 71);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 10;
            this.enemy.TabStop = false;
            this.enemy.Tag = "enemy";
            // 
            // bullet3
            // 
            this.bullet3.BackColor = System.Drawing.Color.Transparent;
            this.bullet3.Image = global::FormGames3.Properties.Resources.bullet;
            this.bullet3.Location = new System.Drawing.Point(70, 12);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(14, 15);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 9;
            this.bullet3.TabStop = false;
            this.bullet3.Tag = "bullet";
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Transparent;
            this.bullet2.Image = global::FormGames3.Properties.Resources.bullet;
            this.bullet2.Location = new System.Drawing.Point(41, 12);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(14, 15);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 8;
            this.bullet2.TabStop = false;
            this.bullet2.Tag = "bullet";
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::FormGames3.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(12, 12);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(14, 15);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 7;
            this.bullet.TabStop = false;
            this.bullet.Tag = "bullet";
            // 
            // key
            // 
            this.key.Image = global::FormGames3.Properties.Resources.key;
            this.key.Location = new System.Drawing.Point(1665, 397);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(90, 47);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.key.TabIndex = 6;
            this.key.TabStop = false;
            this.key.Tag = "key";
            this.key.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormGames3.Properties.Resources.ornament;
            this.pictureBox1.Location = new System.Drawing.Point(1620, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // player
            // 
            this.player.Image = global::FormGames3.Properties.Resources.New_Piskel;
            this.player.Location = new System.Drawing.Point(59, 253);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(62, 56);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FormGames3.Properties.Resources.christmastiles_2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1962, 39);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // background
            // 
            this.background.Image = global::FormGames3.Properties.Resources._4YLH;
            this.background.Location = new System.Drawing.Point(-20, -68);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1993, 597);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM11";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 526);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer5);
            this.Controls.Add(this.axWindowsMediaPlayer4);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.door);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.level1_logo);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.hp3);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.background);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox hp2;
        private System.Windows.Forms.PictureBox hp3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox hp1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox level1_logo;
        private System.Windows.Forms.PictureBox enemy4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

