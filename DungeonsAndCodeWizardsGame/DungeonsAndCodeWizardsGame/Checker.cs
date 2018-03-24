using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Bags;
using DungeonsAndCodeWizardsGame.Models.Items;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame
{
    public class Checker
    {
        public static void IsCharacterInTheParty(List<Character> players, string characterName)
        {
            bool IsItThere = false;

            foreach (var player in players)
            {
                if (player.Name == characterName)
                {
                    IsItThere = true;
                    break;
                }
            }

            if (!IsItThere)
            {
                throw new Exception($"Character {characterName} not found!");
            }
        }

        public static void IsCharacterAlive(Character character)
        {
            if (!character.IsAlive)
            {
                throw new Exception("Must be alive to perform this action!");
            }
        }

        public static void CanYouAddToBag(Bag bag, Item item)
        {
            if (bag.Load + item.Weight > bag.Capacity)
            {
                throw new Exception("Item's weight is too big!");
            }
        }

        public static void IsBagFull(Bag bag)
        {
            if (bag.Load >= bag.Capacity)
            {
                throw new Exception("Bag is full!");
            }
        }

        public static void IsBagEmpty(Bag bag)
        {
            if (bag.Items.Count == 0)
            {
                throw new Exception("Bag is empty!");
            }
        }

        public static void IsItemInTheBag(Bag bag, string itemName)
        {
            bool isItemThere = false;

            foreach (var item in bag.Items)
            {
                if (item.Type == itemName)
                {
                    isItemThere = true;
                }
            }

            if (!isItemThere)
            {
                throw new Exception();
            }
        }

        public static void IsItMe(Character character, Character enemy)
        {
            if (character != enemy)
            {
                throw new Exception("Cannot attack self!");
            }
        }

        public static void AreWeTeam(Character character, Character enemy)
        {
            if (character.Faction.GetType().ToString() == enemy.Faction.GetType().ToString())
            {
                throw new Exception($"Friendly fire! Both characters are {character.Faction.GetType().ToString()} faction!");
            }
        }

        public static void IsTheFactionValid(string factionName)
        {
            if (factionName != "Cpp" && factionName != "CSharp")
            {
                throw new Exception($"Invalid faction: {factionName}!");
            }
        }

        public static void WasGamePlayed()
        {
            if (Engine.IsGameOver)
            {
                string engineHomeText = Engine.Home.Console.Text;

                Engine.CreateHome();

                Engine.Home.Console.Text = engineHomeText;
            }
        }

        public static void AreThereItemsInPool(List<Item> pool)
        {
            if (pool.Count == 0)
            {
                throw new Exception("No left items in the pool!");
            }
        }
    }
}
