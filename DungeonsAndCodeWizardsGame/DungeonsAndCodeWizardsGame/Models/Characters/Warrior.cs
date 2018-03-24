using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Bags;

namespace DungeonsAndCodeWizardsGame.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction) : base(name, 100, 50, 40, new Satchel(), faction)
        {
            this.Type = "Warrior";
        }

        public void Attack(Character character)
        {
            Checker.IsCharacterAlive(this);
            Checker.IsCharacterAlive(character);
            Checker.IsItMe(this, character);
            Checker.AreWeTeam(this, character);

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
