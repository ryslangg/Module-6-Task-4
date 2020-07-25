using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;
using Module_6_Task_4.UI;

namespace Module_6_Task_4.MenuElements
{
    public class BuyItem : ElementMenu
    {
        public override string Title { get; set; } = "Byu item";
        public override string Description { get; set; } = "Byu item";
        public override ConsoleKey Key { get; set; } = ConsoleKey.D3;

        public override void Do(Storage storage, Menu menu)
        {
            Console.WriteLine(storage.Trader.GetItemsInfo());
            Console.WriteLine("Press item number to continue...");
            int number;
            bool isNumeric = false;

            while ( true )
            {
                isNumeric = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out number);

                if ( isNumeric && storage.Trader.CheckItemIndex(number)) {
                    double price = storage.Trader.GetItemPrice(number);

                    if (storage.Client.Balance.CheckAllowForWithdrawal(price))
                    {
                        Item item = storage.Trader.ExtractItemAt(number);
                        storage.Client.AddItem(item);
                        Console.WriteLine("Item purchased!");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds!");
                    }                    
                    break;
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
