using LibraryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItems
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Author: {Author}, Genre: {Genre}\n");
        }
    }
}
