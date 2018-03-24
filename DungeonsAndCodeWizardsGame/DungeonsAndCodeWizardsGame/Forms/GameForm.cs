using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonsAndCodeWizardsGame.Models.Characters;
using DungeonsAndCodeWizardsGame.Models.Items;
using DungeonsAndCodeWizardsGame.Forms;

namespace DungeonsAndCodeWizardsGame
{
    public partial class GameForm : Form
    {

        private List<Character> players;
        private List<Item> pool;

        public GameForm()
        {
            InitializeComponent();
            this.players = new List<Character>();
            this.pool = new List<Item>();
        }

        private void JoinPartyBtn_Click(object sender, EventArgs e)
        {
            JoinPartyForm joinPartyForm = new JoinPartyForm();

            joinPartyForm.ShowDialog();

            if (!joinPartyForm.IsClosed)
            {
                bool isErrorThere = false;

                try
                {
                    string name = joinPartyForm.NameResult.Text;
                    string characterType = joinPartyForm.CharacterTypeResult.Text;
                    string faction = joinPartyForm.FactionResult.Text;

                    Checker.IsTheFactionValid(faction);

                    if (characterType == "Warrior")
                    {
                        players.Add(new Warrior(name, (Faction)Enum.Parse(typeof(Faction), faction)));
                    }
                    else if (characterType == "Cleric")
                    {
                        players.Add(new Cleric(name, (Faction)Enum.Parse(typeof(Faction), faction)));
                    }
                    else
                    {
                        throw new Exception($"Invalid character type {characterType}!");
                    }
                }
                catch (Exception ex)
                {
                    ErrorForm errorForm = new ErrorForm();

                    errorForm.ProblemOutputer.Text += Environment.NewLine + ex.Message;

                    errorForm.ShowDialog();

                    isErrorThere = true;
                }

                if (!isErrorThere)
                {
                    Character lastCharacter = this.players[this.players.Count - 1];
                    this.Console.Text += $"{lastCharacter.Name} joined the game!" + Environment.NewLine;
                }
            }
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Engine.CreateHome();
            Engine.Home.Console.Text = this.Console.Text + "Game Ended";
            Engine.Home.ShowDialog();

            Engine.IsGameOver = true;

            this.Close();
        }

        private void AddItemToPoolBtn_Click(object sender, EventArgs e)
        {
            // TODO: Add Checker.IsCharacterAlive

            AddItemToPoolForm addItemToPoolForm = new AddItemToPoolForm();

            addItemToPoolForm.ShowDialog();

            if (!addItemToPoolForm.isClosed)
            {
                if (addItemToPoolForm.HealthPotion.Checked == true)
                {
                    pool.Add(new HealthPotion());

                    this.Console.Text += $"Health Potion added to the pool!" + Environment.NewLine;
                }
                else if (addItemToPoolForm.PoisonPotion.Checked == true)
                {
                    pool.Add(new PoisonPotion());

                    this.Console.Text += $"Poison Potion added to the pool!" + Environment.NewLine;
                }
                else if (addItemToPoolForm.ArmorRepairKit.Checked == true)
                {
                    pool.Add(new ArmorRepairKit());

                    this.Console.Text += $"Armor Repair Kit added to the pool!" + Environment.NewLine;
                }
            }
        }

        private void PickUpItemBtn_Click(object sender, EventArgs e)
        {
            // TODO: Add Checker.IsCharacterAlive

            PickUpItemForm pickUpItemForm = new PickUpItemForm();

            pickUpItemForm.ShowDialog();

            if (!pickUpItemForm.isClosed)
            {
                try
                {
                    string characterName = pickUpItemForm.CharacterNameResult.Text;

                    Checker.IsCharacterInTheParty(this.players, characterName);
                    Checker.AreThereItemsInPool(this.pool);

                    Item neededItem = this.pool[this.pool.Count - 1];
                    Character neededCharacter = FinderAndSender.GetNeededCharacter(players, characterName);

                    neededCharacter.Bag.AddItem(neededItem);

                    this.Console.Text += $"{characterName} picked up " + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    // TODO: Add logic
                }
            }
        }
    }
}
