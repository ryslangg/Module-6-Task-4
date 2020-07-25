using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;
using Module_6_Task_4.UI;

namespace Module_6_Task_4.MenuElements
{
    public class Exit : ElementMenu
    {
        public override string Title { get; set; } = "Exit";
        public override string Description { get; set; } = "Turn off program";
        public override ConsoleKey Key { get; set; } = ConsoleKey.D5;

        public override void Do(Storage storage, Menu menu)
        {
            menu.Active = false;
        }
    }
}
