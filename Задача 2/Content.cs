
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Content
    {
        private string contentText;

        public Content(string contentText)
        {
            this.contentText = contentText;
        }

        public void Show()
        {
            Console.WriteLine($"Содержание: {contentText}");
        }
    }
}
