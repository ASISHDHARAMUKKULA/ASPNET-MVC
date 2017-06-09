using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public static Book[] GetBooks()
        {
            return new Book[]
            {
                new Book { Title="c# 4.0",Author="Anders",Price=550},
                new Book { Title="ASP.NET",Author="Walther",Price=500},
                new Book { Title="JAVA",Author="Schildt",Price=650},

            };

        }
    }
}


