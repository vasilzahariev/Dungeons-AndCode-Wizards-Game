using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Bags;
using DungeonsAndCodeWizardsGame.Models.Items;

namespace DungeonsAndCodeWizardsGame.Models.Characters
{
    public abstract class Character
    {
        private string name;
        private float health;
        private float armor;
        private bool isAlive;

        public Character(string name, float health, float armor, float abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.IsAlive = true;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.RestHealMultiplier = 0.2f;
            this.Type = "Character";
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty or white space!");
                }

                this.name = value;
            }
        }

        public float BaseHealth { get; private set; }

        public float Health
        {
            get { return this.health; }
            private set
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                    this.health = 0;
                }
                else
                {
                    this.health = Math.Min(value, this.BaseHealth);
                }
            }
        }

        public float BaseArmor { get; private set; }

        public float Armor
        {
            get { return this.armor; }
            private set
            {
                if (value <= 0)
                {
                    this.armor = 0;
                }
                else
                {
                    this.armor = Math.Min(value, this.BaseArmor);
                }
            }
        }

        public float AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public Faction Faction { get; private set; }

        public bool IsAlive
        {
            get { return this.isAlive; }
            private set
            {
                if (!value)
                {
                    // TODO: Write it to the game console
                    Console.WriteLine($"{this.Name} is dead!");
                }

                this.isAlive = value;
            }
        }

        public float RestHealMultiplier { get; protected set; }

        public string Type { get; protected set; }

        public void TakeDamage(float hitPoints)
        {
            Checker.IsCharacterAlive(this);

            if (hitPoints < 0)
            {
                this.Health -= hitPoints;
            }

            if (this.Armor < hitPoints)
            {
                float healthHitPoints = hitPoints - this.Armor;

                this.Health -= healthHitPoints;
            }

            this.Armor -= hitPoints;
        }

        public void ArmorRepairKitMethod()
        {
            this.Armor = this.BaseArmor;
        }

        public void Rest()
        {
            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            Checker.IsCharacterAlive(this);
            Checker.IsItemInTheBag(this.Bag, item.Type);

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            Checker.IsCharacterAlive(this);
            Checker.IsCharacterAlive(character);
            Checker.IsItemInTheBag(this.Bag, item.Type);

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            Checker.IsCharacterAlive(this);
            Checker.IsCharacterAlive(character);

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            this.Bag.AddItem(item);
        }
    }
}
