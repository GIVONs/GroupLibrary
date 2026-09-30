using GroupLibrary.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLibrary.UI
{
    public class UI
    {
        public void ShowMenu()
        {
            string menu = """
                [1] Show all books
                [2] Lend book
                [3] Return book
                [0] Exit

                """;

            int input = InputManagement.MenuInput(menu, 1, 5);
        }

        public bool CloseProgram(string input)
        {
            if (input.ToUpper().Equals("EXIT"))
            {
                Console.WriteLine("Thank you for visiting!");
                return false;
            }
            return true;
        }

        public void MenuChoice()
        {
            bool programRuns = true;
            string menuChoice = Console.ReadLine();

            while (programRuns)
            {
                ShowMenu();

                switch (menuChoice)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;
                }
            }
        }
    }
}
