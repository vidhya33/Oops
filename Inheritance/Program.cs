using System;

class Author
{
    public string Name { get; set; }
    public string Book { get; private set; } = "C# Programming";
    public double Price { get; protected set; }
}
namespace Inheritance
{
    class Program : Author
    {
        static void Main()
        {
            Author author = new Author();
            author.Price = 100;
            /*Program p = new Program();
            p.Price = 50;*/
            author.Name = "titik";

            Console.WriteLine("Author {0}, book {1}, price {2}", author.Name, author.Book, author.Price);

            Console.ReadKey();



        }
    }
}

