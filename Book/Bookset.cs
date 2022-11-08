using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public abstract class Bookset
    {
        public readonly string Name;
        protected string value;
        protected ConsoleColor color;

        public Bookset(string value, string name, ConsoleColor color)
        {
            this.value = value;
            this.Name = name;
            this.color = color;
        }
        public bool EqualName(Bookset property)
        {
            return Name == property.Name;
        }

        public void Show()
        {
            var prevColor = Console.BackgroundColor;
            Console.BackgroundColor = this.color;

            Console.WriteLine($"{value}");

            Console.BackgroundColor = prevColor;
        }
    }
}
