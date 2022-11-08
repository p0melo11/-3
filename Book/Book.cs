using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        private List<Bookset> properties = new List<Bookset>();

        public void AddProperty(Bookset property)
        {
            var index = properties.FindIndex(bookset => bookset.EqualName(property));

            if (index != -1)
            {
                properties.RemoveRange(index, 1);
            }

            properties.Add(property);
        }

        public void Show()
        {
            foreach (var property in properties)
            {
                property.Show();
            }
        }
    }
}
