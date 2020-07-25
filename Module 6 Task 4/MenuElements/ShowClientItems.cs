using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;
using Module_6_Task_4.UI;

namespace Module_6_Task_4.MenuElements
{
    public class ShowClientItems : ElementMenu
    {
        public override string Title { get; set; } = "You items";
        public override string Description { get; set; } = "View you items";
        public override ConsoleKey Key { get; set; } = ConsoleKey.D2;

        public override void Do(Storage storage, Menu menu)
        {
            Console.WriteLine(storage.Client.GetItemsInfo());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
