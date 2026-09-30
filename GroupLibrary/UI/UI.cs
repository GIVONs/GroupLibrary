using GroupLibrary.Models;
using GroupLibrary.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLibrary.UI
{
    public class UI
    {
        public void UserInterface()
        {
            string menu = """
                [1] Show all books
                [2] Rent book
                [3] Return book
                [0] Exit

                """;

            int input = InputManagement.MenuInput(menu, 1, 5);

            switch (input)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
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

    }
}
