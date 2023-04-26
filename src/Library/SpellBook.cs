using System.Collections;
namespace RoleplayGame 
{
    public class SpellBook

    {
        private List<Spell> new List<Spells>() {get;set;}
        public Spellbook()
        {
            this.Spells = new List<Spell>(new Spell("Fireball", 20), new Spell("Magic bolt", 15));
        }
    }
}