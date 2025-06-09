using LibraryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItems
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Month { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Issue: {IssueNumber}, Month: {Month}\n");
        }
    }
}
