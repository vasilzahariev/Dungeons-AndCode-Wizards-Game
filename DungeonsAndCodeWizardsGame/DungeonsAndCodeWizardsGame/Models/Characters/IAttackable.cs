using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizardsGame.Models.Characters
{
    public interface IAttackable
    {
        void Attack(Character character);
    }
}
