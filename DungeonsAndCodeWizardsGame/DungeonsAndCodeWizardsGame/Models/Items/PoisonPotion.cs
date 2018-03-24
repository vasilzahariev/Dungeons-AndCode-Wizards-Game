using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame.Models.Items
{
    public class PoisonPotion : Item
    {
        public PoisonPotion()
        {
            this.Weight = 5;
            this.Type = "PoisonPotion";
        }

        public override void AffectCharacter(Character character)
        {
            Checker.IsCharacterAlive(character);

            character.TakeDamage(20);
        }
    }
}
