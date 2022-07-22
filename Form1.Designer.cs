namespace Ping_Pong
{
    partial class Game_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.Point_lbl = new System.Windows.Forms.Label();
            this.Play_Ground = new System.Windows.Forms.Panel();
            this.High_Score_lbl = new System.Windows.Forms.Label();
            this.Game_Over_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.High_Score_Point_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.Play_Ground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Black;
            this.Racket.Location = new System.Drawing.Point(286, 380);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(200, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(96, 216);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.Score_lbl.Location = new System.Drawing.Point(12, 9);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(79, 28);
            this.Score_lbl.TabIndex = 2;
            this.Score_lbl.Text = "Score : ";
            // 
            // Point_lbl
            // 
            this.Point_lbl.AutoSize = true;
            this.Point_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.Point_lbl.Location = new System.Drawing.Point(87, 9);
            this.Point_lbl.Name = "Point_lbl";
            this.Point_lbl.Size = new System.Drawing.Size(24, 28);
            this.Point_lbl.TabIndex = 3;
            this.Point_lbl.Text = "0";
            // 
            // Play_Ground
            // 
            this.Play_Ground.Controls.Add(this.High_Score_Point_lbl);
            this.Play_Ground.Controls.Add(this.High_Score_lbl);
            this.Play_Ground.Controls.Add(this.Game_Over_lbl);
            this.Play_Ground.Controls.Add(this.Point_lbl);
            this.Play_Ground.Controls.Add(this.Score_lbl);
            this.Play_Ground.Controls.Add(this.Ball);
            this.Play_Ground.Controls.Add(this.Racket);
            this.Play_Ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Play_Ground.Location = new System.Drawing.Point(0, 0);
            this.Play_Ground.Name = "Play_Ground";
            this.Play_Ground.Size = new System.Drawing.Size(800, 450);
            this.Play_Ground.TabIndex = 0;
            // 
            // High_Score_lbl
            // 
            this.High_Score_lbl.AutoSize = true;
            this.High_Score_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.High_Score_lbl.Location = new System.Drawing.Point(12, 48);
            this.High_Score_lbl.Name = "High_Score_lbl";
            this.High_Score_lbl.Size = new System.Drawing.Size(130, 28);
            this.High_Score_lbl.TabIndex = 5;
            this.High_Score_lbl.Text = "High Score : ";
            // 
            // Game_Over_lbl
            // 
            this.Game_Over_lbl.AutoSize = true;
            this.Game_Over_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.Game_Over_lbl.Location = new System.Drawing.Point(407, 126);
            this.Game_Over_lbl.Name = "Game_Over_lbl";
            this.Game_Over_lbl.Size = new System.Drawing.Size(122, 140);
            this.Game_Over_lbl.TabIndex = 4;
            this.Game_Over_lbl.Text = "Game Over\r\n\r\nF1 - Restart\r\n\r\nEsc - Exit\r\n";
            this.Game_Over_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Game_Over_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // High_Score_Point_lbl
            // 
            this.High_Score_Point_lbl.AutoSize = true;
            this.High_Score_Point_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.High_Score_Point_lbl.Location = new System.Drawing.Point(148, 48);
            this.High_Score_Point_lbl.Name = "High_Score_Point_lbl";
            this.High_Score_Point_lbl.Size = new System.Drawing.Size(24, 28);
            this.High_Score_Point_lbl.TabIndex = 6;
            this.High_Score_Point_lbl.Text = "0";
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Play_Ground);
            this.Name = "Game_Form";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.Play_Ground.ResumeLayout(false);
            this.Play_Ground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Racket;
        private PictureBox Ball;
        private Label Score_lbl;
        private Label Point_lbl;
        private Panel Play_Ground;
        private Label Game_Over_lbl;
        private System.Windows.Forms.Timer timer1;
        private Label High_Score_lbl;
        private Label High_Score_Point_lbl;
    }
}