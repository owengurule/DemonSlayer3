using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demons
{

    public enum WeaponClass
    {
        Blade,
        Blunt,
        Axe,
        Flail,
        Dagger

    }

    public class Weapons
    {

        
        public WeaponClass Type { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public Weapons(string n, int damage, WeaponClass type)
        {
            
            this.Name = n;
            this.Damage = damage;
            this.Type = type;
        }
    }

}


