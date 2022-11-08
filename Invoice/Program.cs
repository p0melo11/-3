using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        public static void Main()
        {
            var invoice = new Invoice(23, "Максим", "АТБ");
            invoice.Article = "Молоко";
            invoice.SetQuantity(3);

            invoice.Print();
        }
    }
}
