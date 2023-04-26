namespace RoleplayGame 
{
    public class Armor

    {
        public int Defense {get;set;}
        public Armor(int defensa)
        {
            this.Defense=defensa;
        }

        public int getArmor()
        {
            return this.Defense;
        }
    }
}