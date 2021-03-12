using System;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.Where(b => b.Price > 10).OrderBy(b => b.Title).Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            /*var book = books.Single(b.Title == "ASP.NET MVC"); 
              Console.WriteLine(book.Title);

              var book = books.SingleOrDefault(b.Title == "ASP.NET MVC");
              Console.WriteLine(book.Title);

              var book = books.First(b.Title == "ASP.NET MVC");
              Console.WriteLine(book.Title + " " + book.Price);

              var pagedBooks = books.Skip(2).Take(3);
              foreach (var pagedBook in pagedBooks)
                  Console.WriteLine(pagedBook.Title);

              var maxPrice = books.Max(b => b.Price);
              var minPrice = books.Min(b => b.Price);
              var count = books.Count();
              Console.WriteLine(maxPrice);
              Console.WriteLine(minPrice);
              Console.WriteLine(count); */


            /* LINQ extension methods
                var cheapBooks = books
                                    .Where(b => b.price > 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title); */

            /* LINQ query operators
                var cheapBooks =
                    from b in books
                    where b.Price < 10
                    orderby b.Title
                    select b.title; */
        }
    }
}
