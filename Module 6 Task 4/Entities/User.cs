
using System.Collections.Generic;

namespace Module_6_Task_4.Entities
{
    public class User
    {
        public string Name;
        public Balance Balance;
        public List<Item> Items = new List<Item>();

        public User(string name , double balance)
        {
            Name = name;
            Balance = new Balance(balance);
        }

        public User AddItem(Item item)
        {
            Items.Add(item);
            return this;
        }

        public double GetItemPrice( int number)
        {
            return Items[number].Price;
        }

        public string GetItemsInfo(){
            string itemsInfo = "";
            int i = 0;

            foreach (Item item in Items) 
            {
                itemsInfo += $"{i++}){item.GetInfo()}\r\n";
            }
            return itemsInfo;
        }

        public bool CheckItemIndex(int index)
        {
            if (index < Items.Count)
            {
                return true;
            }
            return false;
        }

        public Item ExtractItemAt(int index)
        {
            Item item = null;

            if (CheckItemIndex(index))
            {
                item = Items[index];
                Items.RemoveAt(index);
            }
            return item;
        }

    }
}
