using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;
using Module_6_Task_4.UI;

namespace Module_6_Task_4.MenuElements
{
    public class Help : ElementMenu
    {
        public override string Title { get; set; } = "Help";
        public override string Description { get; set; } = "Show menu info";
        public override ConsoleKey Key { get; set; } = ConsoleKey.D4;

        public override void Do(Storage storage, Menu menu)
        {
            foreach (ElementMenu element in menu.Elements)
            {
                Console.WriteLine($"{element.Key}){element.GetInfo()}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
