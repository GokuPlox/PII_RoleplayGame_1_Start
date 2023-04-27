namespace RoleplayGame 
{
    public class Weapons

    {
        public int Damage {get; set;}

        public string Name {get; set;}

        public int Defense {get; set;}

        public bool Magic {get; set;}
        public Weapons(string name, int damage, int defense, bool magic)
        {
            this.Damage = damage;
            this.Defense = defense;
            this.Name = name;
            this.Magic = magic;
        }


    }
}