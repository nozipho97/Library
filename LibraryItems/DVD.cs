using LibraryItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItem
{
    public class DVD : LibraryItem
    {
        public int DurationMinutes { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[DVD] ID: {ID}, Title: {Title}, Duration: {DurationMinutes} mins, Year: {YearPublished}");
        }
    }
}

