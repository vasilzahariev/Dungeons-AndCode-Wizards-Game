using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndCodeWizardsGame.Models.Items;

namespace DungeonsAndCodeWizardsGame.Models.Bags
{
    public abstract class Bag
    {
        public Bag()
        {
            this.Capacity = 100;
        }

        public int Capacity { get; protected set; }

        public int Load { get; private set; }

        public List<Item> Items { get; private set; }

        public void AddItem(Item item)
        {
            Checker.CanYouAddToBag(this, item);
            Checker.IsBagFull(this);

            this.Load += item.Weight;
            this.Items.Add(item);
        }

        public Item GetItem(string itemName)
        {
            Checker.IsBagEmpty(this);
            Checker.IsItemInTheBag(this, itemName);

            return FinderAndSender.GetItemFormTheBag(this, itemName);
        }
    }
}
