using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int objectSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santaSleigh.Top += gravity;
            hutDown.Left -= objectSpeed;
            treeDown.Left -= objectSpeed;
            snowFlake.Left -= objectSpeed;
            scoreLabel.Text = $"score: {score }";

            if(hutDown.Left < -100)
            {
                hutDown.Left = 500;
                score++;
            }

            if(treeDown.Left < -100)
            {
                treeDown.Left = 500;
                score++;
            }

            if(snowFlake.Left < -100)
            {
                snowFlake.Left = 500;
            }

            if(santaSleigh.Top < -25)
            {
                gameOver();
            }

            if(santaSleigh.Bounds.IntersectsWith(hutDown.Bounds) || santaSleigh.Bounds.IntersectsWith(treeDown.Bounds) || santaSleigh.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
