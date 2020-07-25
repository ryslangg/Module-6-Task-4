using Module_6_Task_4.Entities;
using Module_6_Task_4.MenuElements;
using Module_6_Task_4.UI;
using System;

namespace Module_6_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage() {
                Client = new User("You", 1000d),
                Trader = new User("Trader", 0d)
            };

            storage.Trader
                    .AddItem(
                        new Item()
                        {
                            Name = "item 1",
                            Price = 100
                        })
                    .AddItem(
                        new Item()
                        {
                            Name = "item 2",
                            Price = 200
                        })
                    .AddItem(
                        new Item()
                        {
                            Name = "item 3",
                            Price = 250
                        })
                    .AddItem(
                        new Item()
                        {
                            Name = "item 4",
                            Price = 500
                        })
                    .AddItem(
                        new Item()
                        {
                            Name = "item 5",
                            Price = 300
                        });

            Menu menu = new Menu();
            menu.AddElement(new ShowTraderItems());
            menu.AddElement(new ShowClientItems());
            menu.AddElement(new BuyItem());
            menu.AddElement(new Help());
            menu.AddElement(new Exit());

            while (menu.Active) {
                Console.Clear();
                menu.Print();
                ConsoleKey selected = Console.ReadKey(true).Key;
                Console.Clear();
                menu.Run(selected, storage);
            }
        }
    }
}
