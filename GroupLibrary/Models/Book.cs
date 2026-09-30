using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLibrary.Models
{
    public class Book
    {
        public int Id { get; private set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool isRented { get; private set; }

        public Book (int Id, string title, string author)
        {
            this.Id = Id;
            this.title = title;
            this.author = author;
        }

        public bool RentBook()
        {
            if (!this.isRented)
            {
                Console.WriteLine($"Success! - Book ID:{this.Id} has been rented");
                return this.isRented = true;
            }
            else
            {
                Console.WriteLine($"Error - The book is allready rented.");
                return null;
            }
        }

        public bool Return()
        {
            if (!this.isRented)
            {
                Console.WriteLine($"Book ID:{this.Id} has been successfully returned.");
                return this.isRented = true;
            } else
            {
                Console.WriteLine($"Request Error: Book ID:{this.Id} is in store.");
                return null;
            }
        }

        public void showStatus()
        {
            if (!this.isRented)
            {
                Console.WriteLine("IN STORAGE");
            }
            else if (this.isRented)
            {
                Console.WriteLine("IS RENTED");
            }
        }
    }
}
