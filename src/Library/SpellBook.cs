using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame 
{
    public class SpellBook

    {
        private List<Spell> Spells;
        public SpellBook()
        {
            this.Spells = new List<Spell>();
            Spells.Add(new Spell("Fireball", 20));
            Spells.Add(new Spell("Magic bolt", 15));
        }
    }
}