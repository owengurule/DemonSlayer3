using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons
{
    class Game
    {

        public Player Player { get; set; }
        public Enemy Enemy { get; set; }


        public Game()
        {

            this.Player = new Player ("Owen", 100);
            this.Enemy = new Enemy ("Demon", 100);

        }

        private void DisplayInfo()
        {

            Console.WriteLine("{0} {1}HP vs {2} {3}HP", Player.Name, Player.HP, Enemy.Name, Enemy.HP);

        }

        public void Play()
        {



            



            while (Player.IsAlive && Enemy.IsAlive)
            {

                DisplayInfo();
                Player.Attack(Enemy);
                Enemy.Attack(Player);

            }

            if(!Player.IsAlive)
            {

                Console.WriteLine("{0} hath been slain", this.Player.Name);

            }
            else
            {

                Console.WriteLine("{0} hath been slain", this.Enemy.Name);

            }

        }
    }
}
