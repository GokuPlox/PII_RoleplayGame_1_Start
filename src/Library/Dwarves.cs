using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Dwarve
    {
        public int Defense {get;set;}
        public int Health {get;set;}
        public int Attack {get;set;}
        public Weapons Weapon {get;set;}
        public List<object> Items {get;set;}
        //public Weapon {get;set;}
        public Dwarve() 
        {
            Weapons arma = new Weapons("pala", 10, 5, false);
            this.Defense=0;
            this.Health=100;
            this.Weapon=arma;
            this.Attack=0;
            Items.Add(Defense);
            Items.Add(Weapon);

        }

        public void AddArmor(Armor tela)
        {
            this.Defense=Defense+tela.Defense;
            
        }

        public void AddWeapon(Weapons w)
        {
            this.Attack=Attack+w.Damage;
            Items.Add(w);
        }

    }
}