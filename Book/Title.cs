using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Title : Bookset
    {
        public Title(string value) : base(value, "Title", ConsoleColor.Green) { }
    }
}
