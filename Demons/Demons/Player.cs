using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons
{
    class Player
    {
        public enum AttackType
        {
            Sword = 1,
            Magic,
            Heal


        }

        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }




        private Random rng = new Random();

        private string _name;

        public string Name
        {
            get { return _name; }
            set { string _name = value; }
        }

        public bool IsAlive
        {

            get { return this.HP > 0; }
        }

        public Player (string name, int startingHP)
        {

            this.Name = name; this.HP = startingHP;
            this.HP = 100;


        }

        private AttackType ChooseAttack()
        {


            Console.WriteLine(@"
            

            
            Sword
            Magic
            Heal

            
            ");

            int input = int.Parse(Console.ReadLine());

            return (AttackType)input;
        }


            public void Attack(Enemy enemy)
            {

                int damage;

                switch (ChooseAttack())
                {

                    case AttackType.Sword:

                        if  (rng.Next(0, 101) > 3)
                        {

                            damage = rng.Next(15, 31);
                            enemy.HP -= damage;
                            Console.WriteLine("{0} deals {1} damage to {2}", this.Name, damage, enemy.Name);

                        }


                        break;
                    case AttackType.Heal:
                        break;
                    default:
                        break;
                }

            }



        }
        
    
}
