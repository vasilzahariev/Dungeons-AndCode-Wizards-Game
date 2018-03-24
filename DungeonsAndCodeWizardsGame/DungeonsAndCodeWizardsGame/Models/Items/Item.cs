using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame.Models.Items
{
    public abstract class Item
    {
        public Item()
        {
            this.Weight = 0;
        }

        public int Weight { get; protected set; }

        public string Type { get; protected set; }

        public virtual void AffectCharacter(Character character)
        {
        }
    }
}
