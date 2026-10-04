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
        
        public async Task UserInterface()

        {
            bool running = true; 
            while (running)
            {

                string menu = """
                [1] Show all books
                [2] Find Book
                [3] Rent book
                [4] Return book
                [5] Exit app

                """;

                Console.Clear();
                MenuHeader("LIBRARY");
                var result = InputManagement.MenuInput(menu, 1, 5);

                switch (result)
                {
                    case 1:
                        Console.Clear();

                        MenuHeader("ALL BOOKS");
                        PrintBook(library.GetBooks());
                        running = CloseProgram();
                 
                        break;

                    case 2:
                        Console.Clear();

                        MenuHeader("FIND BOOK");
                        SearchMenu();
                        result = InputManagement.ChoiceInput(1, 3);
                        switch (result)
                        {
                            case 1:
                                MenuHeader("Find by Book-ID");
                                Book? findBook = library.findBook(0);
                                break;

                            case 2:

                                break;

                            case 3:
                                continue;

                        }
                        break;

                    case 3:
                        Console.Clear();

                        MenuHeader("RENT BOOK");
                        Book? bookToRent = library.findBook(0);

                        if (bookToRent != null)
                        {
                            bookToRent.RentBook();
                        }
                        running = CloseProgram();
                        break;

                    case 4:
                        Console.Clear();

                        Book? bookToReturn = library.findBook(0);
                        if (bookToReturn != null)
                        {
                            bookToReturn.Return();
                        }
                        running = CloseProgram();
                        break;

                    case 5:

                        running = CloseProgram();
                        break;

                }
            }
           
        }

        private void MenuHeader(string text1)
        {
            Console.WriteLine(new string('-', 62));
            Console.WriteLine(text1);
            Console.WriteLine(new string('-', 62));
        }

        private void SearchMenu()
        {
            Console.WriteLine(
                """
                Hur vill du söka boken?

                [1] Sök med Bok-ID

                [2] Sök med ord

                [3] Gå tillbaka

                """);
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
