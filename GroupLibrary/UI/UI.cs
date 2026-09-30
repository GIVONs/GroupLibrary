using GroupLibrary.DB;
using GroupLibrary.Models;
using GroupLibrary.System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GroupLibrary
{
    public class UI
    {
        Bibliotek library = new Bibliotek();
        
        public void UserInterface()

        {
            bool running = true; 
            while (running)
            {

                string menu = """
                [1] Show all books
                [2] Rent book
                [3] Return book
                [4] Exit app

                """;

                Console.WriteLine(new string('-', 62));
                Console.WriteLine("LIBRARY");
                Console.WriteLine(new string('-', 62));
                var result = InputManagement.MenuInput(menu, 1, 4);
                Console.Clear(); // Kan ta bort denna ifall det känns som att den förstör 

                switch (result)
                {
                    case 1:

                        Console.WriteLine(new string('-', 62));
                        Console.WriteLine("ALL BOOKS\n");
                        PrintBook(library.GetBooks());
                        running = CloseProgram();
                 
                        break;

                    case 2:

                        Console.WriteLine(new string('-', 62));
                        Console.WriteLine("RENT BOOK");
                        Console.WriteLine(new string('-', 62));
                        Book? bookToRent = library.findBook(0);

                        if (bookToRent != null)
                        {
                            bookToRent.RentBook();
                        }
                        running = CloseProgram();

                        break;

                    case 3:

                        Book? bookToReturn = library.findBook(0);
                        if (bookToReturn != null)
                        {
                            bookToReturn.Return();
                        }
                        running = CloseProgram();

                        break;

                    case 4:

                        running = CloseProgram();
                        break;

                }
            }
           
        }

        private void PrintBook(List<Book> books)
        {
            Console.WriteLine($"{"ID", -5}{"Title", -28}{"Author", -18}Status");
            Console.WriteLine(new string('-', 62));

            foreach (Book book in books)
            {
                string status = book.isRented ? "Rented" : "Available";
                Console.WriteLine($"{book.Id, -5}{book.title, -28}{book.author, -18}{status}");
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 62));

        }

        public bool CloseProgram()
        {
            Console.WriteLine("\nPress Enter to return to menu, or type 'exit' to close the program.");
            string input = Console.ReadLine();

            if (input.ToUpper().Trim().Equals("EXIT"))
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.Clear();
            }
            
            return true;
        }

    }
}
