using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score_int;
        int highScore_int;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;




        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;

            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Stop();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Start();
            }
        }

        private void startGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void takeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored " + score_int + " and my highscore is " + highScore_int + " in the Snake Game 2022\nMade By Team Udaipur";
            caption.BackColor = Color.Black;
            caption.Font = new Font("Monaco", 12);
            caption.ForeColor = Color.NavajoWhite;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snapshot of Snake Game by Team Udaipur";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;    

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);


            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;

                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    if (food.X == Snake[i].X && food.Y == Snake[i].Y)
                    {
                        EatFood();
                    }

                    for (int j = Snake.Count - 1; j > 0; j--)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;

                }


            }
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColor;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.DeepSkyBlue;
                }
                else
                {
                    snakeColor = Brushes.LightCyan;
                }

                canvas.FillEllipse(snakeColor, new Rectangle(
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));


            }

            canvas.FillEllipse(Brushes.Gold, new Rectangle(
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height));
        }

        private void clear(object sender, EventArgs e)
        {
            highScore_int = 0;
            highscore.Text = "" + highScore_int;

        }

        private void showCred(object sender, EventArgs e)
        {
            if (credBtn.Text == "CREDITS")
            {
                devTile.Visible = true;
                credBtn.Text = "HIDE";
            }
            else if (credBtn.Text == "HIDE")
            {
                devTile.Visible = false;
                credBtn.Text = "CREDITS";
            }
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            gameTimer.Interval = 110;
            Snake.Clear();

            startButton.Enabled = false;
            startButton.Text = "START";
            snapButton.Enabled = false;
            clearButton.Enabled = false;
            credBtn.Enabled = false;

            devTile.Visible = false;

            score_int = 0;
            score.Text = "" + score_int;

            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();



        }

        private void EatFood()
        {
            Circle circle = new Circle();
            Snake.Add(circle);
            score_int += 1;
            score.Text = "" + score_int;
            if (score_int > highScore_int)
            {
                highScore_int = score_int;
                highscore.Text = "" + highScore_int;
            }
            food = new Circle() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            if ((score_int % 2 == 0 && score_int > 0) && gameTimer.Interval > 35)
            {
                gameTimer.Interval -= 5;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;
            clearButton.Enabled = true;
            credBtn.Enabled = true;
        }
    }
}
