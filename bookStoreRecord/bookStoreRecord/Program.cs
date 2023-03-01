using System;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace bookstorerecord
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Bookstore(10, "Ruination", "Anthony Reynolds", 13.99);
            var book2 = new Bookstore(20, "Rise of the Red Hand", "Jason Lancour0", 6.99);
            var book3 = new Bookstore(30, "The Lord of the Rings", "J.R.R. Tolkien", 129.510);
            OutputBooks(book1);
            OutputBooks(book2);
            OutputBooks(book3);
        }
        public record Bookstore(int ID, string Title, string Author, double Price);
        public static void OutputBooks(Bookstore book)
        {
            WriteLine($"Book {book.ID}: {book.Title} written by {book.Author} sells for {book.Price.ToString("C2")}");
        }
    }
}