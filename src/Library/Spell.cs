namespace RoleplayGame 
{
    public class Spell

    {
        private int Attack {get;}
        private string Name {get;}
        public Spell(string nombre, int ataque)
        {
            this.Name = nombre;
            this.Attack = ataque;
        }
    }
}