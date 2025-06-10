using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItem
{
    public class LibraryManager
    {
        public List<LibraryItem> Items { get; set; } = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("\n Library Items:");
            foreach (var item in Items)
            {
                item.Display();
            }
        }
    }
}