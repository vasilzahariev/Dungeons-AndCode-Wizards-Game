using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Bags;

namespace DungeonsAndCodeWizardsGame.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) : base(name, 50, 25, 40, new Backpack(), faction)
        {
            this.Type = "Cleric";
            this.RestHealMultiplier = 0.5f;
        }

        public void Heal(Character character)
        {
            character.TakeDamage(-20);
        }
    }
}
