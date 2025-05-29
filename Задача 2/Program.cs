using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // Создаем объекты Title, Author и Content
                Title title = new Title("Арнольд Шварценеггер");
                Author author = new Author("София");
                Content content = new Content("Познавательно");

                // Создаем объект книги и передаем ему Title, Author и Content
                Book book = new Book(title, author, content);

                // Показываем книгу
                book.ShowBook();
            Console.ReadLine();
            
        }
    }
}
