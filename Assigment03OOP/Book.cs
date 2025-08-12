using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03OOP
{
    class Book
    {
        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        #endregion
        #region Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        } 
        #endregion
    }
}
