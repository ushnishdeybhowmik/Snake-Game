namespace Snake_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.devTile = new System.Windows.Forms.Label();
            this.credBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Font = new System.Drawing.Font("Monaco", 12F);
            this.startButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.startButton.Location = new System.Drawing.Point(12, 657);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(5);
            this.startButton.Size = new System.Drawing.Size(99, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.snapButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.snapButton.FlatAppearance.BorderSize = 0;
            this.snapButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.snapButton.Font = new System.Drawing.Font("Monaco", 12F);
            this.snapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snapButton.Location = new System.Drawing.Point(135, 657);
            this.snapButton.Name = "snapButton";
            this.snapButton.Padding = new System.Windows.Forms.Padding(5);
            this.snapButton.Size = new System.Drawing.Size(99, 41);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "SNAP";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.takeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(624, 624);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Cyan;
            this.scoreLabel.Location = new System.Drawing.Point(668, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Padding = new System.Windows.Forms.Padding(5);
            this.scoreLabel.Size = new System.Drawing.Size(64, 29);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "SCORE";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Cyan;
            this.score.Location = new System.Drawing.Point(687, 64);
            this.score.Name = "score";
            this.score.Padding = new System.Windows.Forms.Padding(5);
            this.score.Size = new System.Drawing.Size(28, 29);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLabel.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.highscoreLabel.Location = new System.Drawing.Point(647, 111);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Padding = new System.Windows.Forms.Padding(5);
            this.highscoreLabel.Size = new System.Drawing.Size(109, 29);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "HIGH SCORE";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.Color.Transparent;
            this.highscore.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.Color.DarkMagenta;
            this.highscore.Location = new System.Drawing.Point(687, 149);
            this.highscore.Name = "highscore";
            this.highscore.Padding = new System.Windows.Forms.Padding(5);
            this.highscore.Size = new System.Drawing.Size(28, 29);
            this.highscore.TabIndex = 2;
            this.highscore.Text = "0";
            this.highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearButton.Font = new System.Drawing.Font("Monaco", 12F);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(258, 657);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(5);
            this.clearButton.Size = new System.Drawing.Size(99, 41);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clear);
            // 
            // devTile
            // 
            this.devTile.AutoSize = true;
            this.devTile.BackColor = System.Drawing.Color.Black;
            this.devTile.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devTile.ForeColor = System.Drawing.Color.Chartreuse;
            this.devTile.Location = new System.Drawing.Point(142, 149);
            this.devTile.Name = "devTile";
            this.devTile.Size = new System.Drawing.Size(337, 338);
            this.devTile.TabIndex = 3;
            this.devTile.Text = "Developed By Team Udaipur\r\n\r\nUshnish Dey Bhowmik\r\n\r\nAmogh Korde\r\n\r\nOmkar Chavan\r\n" +
    "\r\nAnushka Mhalankar\r\n\r\nShahzmeen Shaikh\r\n\r\nGladson David\r\n";
            this.devTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devTile.Visible = false;
            // 
            // credBtn
            // 
            this.credBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.credBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.credBtn.FlatAppearance.BorderSize = 0;
            this.credBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.credBtn.Font = new System.Drawing.Font("Monaco", 12F);
            this.credBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.credBtn.Location = new System.Drawing.Point(384, 656);
            this.credBtn.Name = "credBtn";
            this.credBtn.Padding = new System.Windows.Forms.Padding(5);
            this.credBtn.Size = new System.Drawing.Size(99, 41);
            this.credBtn.TabIndex = 0;
            this.credBtn.Text = "CREDITS";
            this.credBtn.UseVisualStyleBackColor = false;
            this.credBtn.Click += new System.EventHandler(this.showCred);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(768, 723);
            this.Controls.Add(this.devTile);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.credBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(788, 788);
            this.MinimumSize = new System.Drawing.Size(788, 766);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic Snakes 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label devTile;
        private System.Windows.Forms.Button credBtn;
    }
}

