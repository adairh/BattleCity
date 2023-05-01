using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleCity
{
    class LevelGame
    {
        private int speed = 0;
        public int level = 0;
        private Label label;
        private Timer timer = new Timer();
        
        public LevelGame() { }
        public LevelGame(Label label)
        {
            this.label = label;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
        }
        
        public void Animation()
        {
            label.Visible = true;
            timer.Start();
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            if (level != 8)
            {
                label.Text = (speed % 2 == 0) ? $"Level {level}" : "";
            }
            else
            {
                label.Text = (speed % 2 == 0) ? "YOU WIN !!!" : "";
            }
            if (speed > 150)
            {
                speed = 0;
                timer.Stop();
                label.Visible = false;
            }
            speed++;
        }
    }
}