using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{

    public class Author : Bookset
    {
        public Author(string value) : base(value, "Author", ConsoleColor.Blue) { }
    }
}