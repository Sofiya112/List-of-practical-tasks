using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void ShowBook()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
