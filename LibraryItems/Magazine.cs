using LibraryItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItem
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[Magazine] ID: {ID}, Title: {Title}, Issue: {IssueNumber}, Year: {YearPublished}");
        }
    }
}
