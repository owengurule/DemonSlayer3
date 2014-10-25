using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons
{
    class Program
    {




        



        static void Main(string[] args)



        {

            List<Weapons> WeaponsToChoose = new List<Weapons>() 
        {
            new Weapons("Deadly Puncture(Dagger)", 15, WeaponClass.Dagger),
            new Weapons("Razors Edge(Katana)", 20, WeaponClass.Blade),
            new Weapons("Hells Hammer(Warhammer)", 30, WeaponClass.Blunt),
            new Weapons("Saurons Swinger(Flail)", 25, WeaponClass.Flail),
            new Weapons("Ferocious BattleAxe(Axe)", 18, WeaponClass.Axe) 
        };



            bool isInUse = false;


            bool inputValidation = false;

            int inputNum = 5;


            Console.WriteLine("press 1,2,3,4,5 to choose weapon");
            char weaponSelect = Console.ReadKey().KeyChar;
            if (char.IsDigit(weaponSelect))
            {

                inputNum = int.Parse(weaponSelect.ToString());
                inputValidation = true;

                if (inputNum.Equals(1))
                {
                    WeaponsToChoose.Clear();
                    WeaponsToChoose.Add(new Weapons("Deadly Puncture(Dagger)", 15, WeaponClass.Dagger));

                    isInUse = true;
                    foreach (Weapons item in WeaponsToChoose)
                    {
                        while (isInUse)
                        {
                            return Player.AttackType.Attack + Player.AttackType.Attack.totalDam + (15);
                        }
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("INPUT WAS INVALID CHOOSE A NUMBER 1 - 5  \n press 1,2,3,4,5 to choose weapon");
                char weaponReselect = Console.ReadKey().KeyChar;
                if (char.IsDigit(weaponSelect))
                {

                    inputNum = int.Parse(weaponReselect.ToString());
                    inputValidation = true;


                }
            }



            





            Game myGame = new Game();

            myGame.Play();
            Console.ReadKey();


        }
    }
}
