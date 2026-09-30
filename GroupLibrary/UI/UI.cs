using GroupLibrary.DB;
using GroupLibrary.Models;
using GroupLibrary.System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GroupLibrary.UI
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
                [4] Exit

                """;
                Console.WriteLine(menu);
                Console.WriteLine("Gör ett menyval mellan 1-4");
                string input = Console.ReadLine();

                InputManagement.MenuInput(menu, 1, 5);

                switch (input)
                {
                    case "1":
                        Console.WriteLine("ALLA BÖCKER");

                        foreach (Book book in library.GetBooks())
                        {
                            Console.WriteLine();
                            Console.WriteLine(book);
                            Console.WriteLine();
                        }

                        break;

                    case "2":
                        Console.WriteLine("Enter ID for book to rent: ");
                        string rentInput = Console.ReadLine();

                        if (!int.TryParse(rentInput, out int lendId))
                        {
                            Console.WriteLine("Invalid ID - Must be an integer. ");
                            break;
                        }

                        Book? foundBook = library.findBook(lendId);
                        if (foundBook == null)
                        {
                            Console.WriteLine("Ingen bok med det IDt hittades.");
                        }
                        else if (foundBook.RentBook())
                        {
                            Console.WriteLine($"{foundBook.title} has been rented.");
                        }
                        else
                        {
                            Console.WriteLine($"{foundBook.title} is not available.");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Enter ID for book to rent: ");
                        string returnInput = Console.ReadLine();

                        if (!int.TryParse(returnInput, out int returnId))
                        {
                            Console.WriteLine("Invalid ID - Must be an integer. ");
                            break;
                        }

                        Book? returnBook = library.findBook(returnId);
                        if (returnBook == null)
                        {
                            Console.WriteLine("Ingen bok med det IDt hittades.");
                        }
                        else if (returnBook.RentBook())
                        {
                            Console.WriteLine($"{returnBook.title} has been rented.");
                        }
                        else
                        {
                            Console.WriteLine($"{returnBook.title} is not available.");
                        }

                        break;

                    case "4":
                        running = CloseProgram();
                        break;
                }
            }
           
        }

        public bool CloseProgram()
        {
            Console.WriteLine("Thank you for visiting!");
            return false;
        }

    }
}
