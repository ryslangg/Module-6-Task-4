using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Module_6_Task_4.Entities
{
    public class Item
    {
        public string Name;
        public double Price;

        public string GetInfo()
        {
            return $"{Name} (${Price})";
        }
    }
}
