using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    class Book
    {
        string bookName;
        string author;
        int pageAmount;

        public Book (string _bookName, string _author, int _pageAmount)
        {
            this.bookName = _bookName;
            this.author = _author;
            this.pageAmount = _pageAmount;
        }

        public string BookName
        {
            get { return this.bookName; }
            set { this.bookName = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int PageAmount
        {
            get { return this.pageAmount; }
            set { this.pageAmount = value; }
        }
    }
}
