namespace RoleplayGame
{
    public class Elves
    {
          public int Attack {get;set;} 
          public int Defense {get;set;}

          public int Health {get;set;}

          public string Weapon {get;set;}

        public Elves (int attack,int defense, int health, string weapon)
        {
            this.Attack=attack;
            this.Defense=defense;
            this.Health=health;
            this.Weapon=weapon;
        }  
    }
       
    
}