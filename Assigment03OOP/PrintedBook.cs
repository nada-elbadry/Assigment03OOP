using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03OOP
{
    class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return base.ToString() + $", Page Count: {PageCount}";
        }
    }
}
