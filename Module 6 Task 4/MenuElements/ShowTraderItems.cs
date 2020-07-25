using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;
using Module_6_Task_4.UI;

namespace Module_6_Task_4.MenuElements
{
    public class ShowTraderItems : ElementMenu
    {
        public override string Title { get; set; } = "Seller's products";
        public override string Description { get; set; } = "View items from the seller";
        public override ConsoleKey Key { get; set; } = ConsoleKey.D1;

        public override void Do(Storage storage, Menu menu)
        {
            Console.WriteLine(storage.Trader.GetItemsInfo());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
