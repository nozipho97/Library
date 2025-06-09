using LibraryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItems
{
    public abstract class DVD : LibraryItem
    {
        public string Director { get; set; }
        public double Duration { get; set; } // in hours

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Director: {Director}, Duration: {Duration} hours\n");
        }
    }
}
