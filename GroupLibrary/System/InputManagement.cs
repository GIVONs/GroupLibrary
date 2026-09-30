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
        public static int InputControl(string text)
        {
            while (true)
            {
                Console.WriteLine(text);

                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Försök igen");
                }
                else return id;
            }
        }
    }
}
