using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Items;
using DungeonsAndCodeWizardsGame.Models.Bags;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame
{
    public class FinderAndSender
    {
        private static Character neededCharacter;

        public static Item GetItemFormTheBag(Bag bag, string itemName)
        {
            foreach (var item in bag.Items)
            {
                if (item.Type == itemName)
                {
                    Item neededItem = item;

                    bag.Items.Remove(item);

                    return neededItem;
                }
            }

            throw new Exception("Imposible!");
        }

        public static void ColectCharacter(Character character)
        {
            neededCharacter = character;
        }

        public static Character AddToCharacters()
        {
            return neededCharacter;
        }

        public static Character GetNeededCharacter(List<Character> players, string characterName)
        {
            foreach (var player in players)
            {
                if (player.Name == characterName)
                {
                    return player;
                }
            }

            throw new Exception();
        }
    }
}
