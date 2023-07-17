using System;
using System.Drawing;
using System.Windows.Forms;

namespace Testing.Forms
{
    public partial class Сapcha_Form : Form
    {
        private string capcha;
        private byte counter_Incorrectly_Entered_Captchas;

        public Сapcha_Form()
        {
            InitializeComponent();
            Capcha_PictureBox.Image = CreateImage(Capcha_PictureBox.Width, Capcha_PictureBox.Height);
        }

        private void Draws_Lines(Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, new Point(0, 0), new Point(Width - 1, Height - 1));
            graphics.DrawLine(Pens.Black, new Point(0, Height - 1), new Point(Width - 1, 0));
        }

        private void Blocks_Form()
        {
            MessageBox.Show("В целях безопастности доступ к форме заблокирован на ограниченое время!");
            Change_Button.Enabled = false;
            Сonfirm_Button.Enabled = false;
            Capcha_TextBox.Enabled = false;
            Block_Timer.Start();
            counter_Incorrectly_Entered_Captchas = 0;
        }

        private void Block_Timer_Tick(object sender, EventArgs e)
        {
            Block_Timer.Stop();
            Change_Button.Enabled = true;
            Сonfirm_Button.Enabled = true;
            Capcha_TextBox.Enabled = true;
            MessageBox.Show("Блокировка снята!");
            Block_Timer.Interval += Block_Timer.Interval;
            Capcha_PictureBox.Image = CreateImage(Capcha_PictureBox.Width, Capcha_PictureBox.Height);
        }

        private void Draws_Captcha(Graphics graphics, string capcha, int Width, int Height)
        {
            var rnd = new Random();
            int Xpos = rnd.Next(0, Width - 150);
            int Ypos = rnd.Next(15, Height - 50);

            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Green };
            graphics.DrawString(capcha, new Font("Segoe UI Variable Small Semibol", 30),
                colors[rnd.Next(colors.Length)], new PointF(Xpos, Ypos));
        }

        private string Forms_Captcha()
        {
            var rnd = new Random();
            var capcha = string.Empty;
            string symbols = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";

            for (int i = 0; i < 5; ++i)
            {
                capcha += symbols[rnd.Next(symbols.Length)];
            }

            return capcha;
        }

        private Bitmap Draws_Interference(Bitmap result, int Width, int Height)
        {
            var rnd = new Random();

            for (int i = 0; i < Width; ++i)
            {
                for (int j = 0; j < Height; ++j)
                {
                    if (rnd.Next() % 20 == 0)
                    {
                        result.SetPixel(i, j, Color.White);
                    }
                }
            }
            return result;
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            var rnd = new Random();
            var result = new Bitmap(Width, Height);
            var graphics = Graphics.FromImage(result);
            graphics.Clear(Color.Gray);

            capcha = Forms_Captcha();
            Draws_Captcha(graphics, capcha, Width, Height);
            Draws_Lines(graphics);
            result = Draws_Interference(result, Width, Height);

            return result;
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Capcha_PictureBox.Image = CreateImage(Capcha_PictureBox.Width, Capcha_PictureBox.Height);
        }

        private void Сonfirm_Batton_Click(object sender, EventArgs e)
        {
            if (Capcha_TextBox.Text == capcha)
            {
                MessageBox.Show("Верно!");
                var avtorization = new Avtorization_Form();
                avtorization.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Не верно!");
                counter_Incorrectly_Entered_Captchas++;
                Capcha_PictureBox.Image = CreateImage(Capcha_PictureBox.Width, Capcha_PictureBox.Height);

                if (counter_Incorrectly_Entered_Captchas == 2)
                {
                    Blocks_Form();
                }
            }
        }
    }
}
