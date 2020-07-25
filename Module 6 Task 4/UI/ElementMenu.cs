using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_4.Entities;

namespace Module_6_Task_4.UI
{
    public class ElementMenu
    {
        public virtual string Title { get; set; } = "Some";
        public virtual string Description { get; set; } = "Some menu element";
        public virtual ConsoleKey Key { get; set; } = ConsoleKey.D1;

        public virtual bool CheckKeyFits(ConsoleKey key)
        {
            return (key == Key);
        }

        public virtual void Do(Storage storage, Menu menu) {
            
        }

        public virtual string GetInfo()
        {
            return $"{Title} - {Description}";
        }
    }
}
