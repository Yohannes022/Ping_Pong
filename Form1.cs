namespace Ping_Pong
{
    public partial class Game_Form : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public int highScorePoint = 0;
        public Game_Form()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            Racket.Top = Play_Ground.Bottom - (Play_Ground.Bottom / 10);

            Game_Over_lbl.Left = (Play_Ground.Width / 2) - (Game_Over_lbl.Width / 2);
            Game_Over_lbl.Top = (Play_Ground.Height / 2) - (Game_Over_lbl.Height / 2);
            Game_Over_lbl.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            Ball.Left += speed_left;
            Ball.Top += speed_top;

            if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                highScorePoint = points;
                Point_lbl.Text = points.ToString();
                High_Score_Point_lbl.Text = highScorePoint.ToString();

                Random r = new Random();
                Play_Ground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (Ball.Left <= Play_Ground.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right >= Play_Ground.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= Play_Ground.Top)
            {
                speed_top = -speed_top;
            }
            if (Ball.Bottom >= Play_Ground.Bottom)
            {
                timer1.Enabled = false;
                Game_Over_lbl.Visible = true;
            }
        }

        private void Game_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                Point_lbl.Text = points.ToString();
                High_Score_Point_lbl.Text = highScorePoint.ToString();
                timer1.Enabled = true;
                Game_Over_lbl.Visible = false;
                Play_Ground.BackColor = Color.White;
            }
        }
    }
}