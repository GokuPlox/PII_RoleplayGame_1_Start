
namespace RoleplayGame
{
    public class Dwarve
    {
        public int Defense {get;set;}
        public int Health {get;set;}
        public int Attack {get;set;}
        //public Weapon {get;set;}
        public Dwarve() 
        {
            this.Defense=10;
            this.Health=100;
            this.Weapon=null;
            this.Attack=5;

        }

        public void AddArmor(Armor tela)
        {
            this.Defense=Defense+tela.getArmor();
        }


    }
}