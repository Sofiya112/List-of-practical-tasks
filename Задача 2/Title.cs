using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Title
    {
        private string titleName;

        public Title(string titleName)
        {
            this.titleName = titleName;
        }

        public void Show()
        {
            Console.WriteLine($"Название книги: {titleName}");
        }
    }
}
