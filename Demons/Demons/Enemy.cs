using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons
{
    class Enemy
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { string _name = value.ToUpper() ; }
        }

        private Random rng = new Random();

        private int _hp;

        public int HP
        {

        get { return _hp; }
        set { _hp = value;}

        }
        
        public bool IsAlive
        {

            get { return this.HP > 0; }

        }

        public Enemy(string name, int startingHP)
        {

            this.HP = startingHP;
            this.Name = name;

        }

        public void Attack(Player Player)
        {


            if (rng.Next(0, 101) > 2)
	    {
		 int damage = rng.Next(5, 16);

                Player.HP -= damage;

                Console.WriteLine("{0} hit you for {1} damage", this.Name, Player.Name, damage);
	    }
            else
        {
            Console.WriteLine("{0} missed {1}", this.Name, Player.Name);
        }


        }

    }
}
