using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Content : Bookset
    {
        public Content(string value) : base(value, "Content", ConsoleColor.Red) { }
    }
}
