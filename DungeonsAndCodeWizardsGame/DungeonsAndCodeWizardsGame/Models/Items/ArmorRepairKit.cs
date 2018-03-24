using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame.Models.Items
{
    public class ArmorRepairKit : Item
    {
        public ArmorRepairKit()
        {
            this.Weight = 10;
            this.Type = "ArmorRepairKit";
        }

        public override void AffectCharacter(Character character)
        {
            Checker.IsCharacterAlive(character);

            character.ArmorRepairKitMethod();
        }
    }
}
