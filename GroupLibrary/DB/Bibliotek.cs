using GroupLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;



namespace GroupLibrary.DB
{
    
    public class Bibliotek
    {

        public List<Book> books = new List<Book>();
        public Bibliotek()
        {
            Book book1 = new Book(1, " Harry Potter", ("JK Rowling"));
            Book book2 = new Book(2, " The hobbit", "JR Tolkien");
            Book book3 = new Book(3, " The return of the king", "JR Tolkien");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

        }
    public Book? findBook(int id)
        {
            Console.Write("ID-number: ");
            id = Convert.ToInt16(Console.ReadLine());
            foreach (Book i in books)
            {
                if (i.Id == id)
                {
                    Console.WriteLine($"\nFound, Book id: {i.Id} Title: {i.title}, Author: {i.author}.");
                    return i;
                }
            }
            Console.WriteLine("Failed to find ID, book does not exist or wrong ID input.");
            return null;
        }
        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public List<Book> GetAvailableBooks()
        {
            foreach (Book i in books)
            {
                if (!i.isRented == false)
                {
                    Console.WriteLine($"Found book id: {i.Id} Title: {i.title}, Author: {i.author}.");
                    return new List<Book>(books);
                }
            }
            return null;
        }
    }

}
