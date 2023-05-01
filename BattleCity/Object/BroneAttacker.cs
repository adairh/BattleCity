using System.Drawing;
using System.Windows.Forms;

namespace BattleCity
{
    class BroneAttacker : Attacker
    {
        // Constructor
        public BroneAttacker(PictureBox map) : base(map)
        {
            Map = map;
        }

        public BroneAttacker(PictureBox map, Point location, Direction direction) : base(map)
        {
            vt = location;
            this.direction = direction;
            state = FigureState.weak;
            MakeAttacker();
            timeDelay = 150;
            maxHealth = 100;
            speed = 2;
            Avatar.Height = 40;
            Avatar.Width = 40;
        }

        // Method
        public override void MakeAttacker()
        {
            skin.MakeAttacker1();
        }

        public override void AttackerShoot()
        {
            if (timeDelay == 0)
            {
                Shoot();
                timeDelay = 100;
            }
            else
            {
                timeDelay--;
            }
        }
    }
}
