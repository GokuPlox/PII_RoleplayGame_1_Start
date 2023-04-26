namespace RoleplayGame
{
    public class Elves
    {
        public int Attack {get;set;} 
        public int Defense {get;set;}

        public int Health {get;set;}

        public Weapons Weapon {get;set;}

        public Elves (int attack,int defense, int health, Weapons weapon)
        {
            this.Attack=attack;
            this.Defense=defense;
            this.Health=health;
            this.Weapon=weapon;
        }  
    }

}