using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItem
{
    internal class LibraryItem
    {
        public abstract LibraryItem
        {
            public List<LibraryItem> Items { get; set; } = new List<LibraryItem>();
            public void AddItem(LibraryItem item)
            {
                Items.Add(item);
            }
            public abstract void DisplayItems()
            {
                foreach (var item in Items)
                {
                    item.Display();
                }
            }
        }
    
            public string ID { get; set; }
            public string Title { get; set; }
            public int YearPublished { get; set; }

            public abstract void Display()
            {
                Console.WriteLine($"ID: {ID}, Title: {Title}, Year: {YearPublished}");
            }
        
    }
}
