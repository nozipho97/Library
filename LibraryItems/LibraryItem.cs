using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItem
{
    public abstract class LibraryItem
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }

        public abstract void Display();
    }
}
