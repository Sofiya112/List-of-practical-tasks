using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Author
    {
        private string authorName;

        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.WriteLine($"Автор: {authorName}");
        }


    }
}
