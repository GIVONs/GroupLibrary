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

            InputManagement.MenuInput();

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
