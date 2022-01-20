using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        bool finished = false;

        while (!finished)
        {
            Console.Write("Enter a capital letter or '1' to quit: ");

            string response = Console.ReadLine();

            char letter = response[0];

            if (letter == '1')
            {
                finished = true;
            }
            else if (letter.ToString().ToUpper() != letter.ToString())
            {

            }
            else
            {
                string diamond = Diamond.Make(letter);

                Console.WriteLine(diamond);
            }
        }
    }
}

