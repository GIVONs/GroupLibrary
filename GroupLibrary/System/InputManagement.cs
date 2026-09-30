using System;
using System.Collections.Generic;
using System.Text;

namespace GroupLibrary.System
{
    public class InputManagement
    {
        public static int MenuInput(string menu, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(menu);

                if (!int.TryParse(Console.ReadLine(), out int input) || input < min || input > max)
                {
                    Console.WriteLine($"försök igen, välj mellan {min} och {max}");
                }
                else
                    return input;
            }
        }
    }
}
