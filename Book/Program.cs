using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        public static void Main()
        {
            var book = new Book();

            Bookset[] props = { new Title("1984"), new Author("Джордж Орвелл"), new Content("У листi до свого видавця Фреда Ворбурга 22 жовтня 1948 року Орвелл повiдомив ...") };

            foreach (var property in props)
            {
                book.AddProperty(property);
            }

            book.Show();
        }
    }
}
