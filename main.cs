using System;

namespace LedNumbers
{
    class Program
    {
        static void Main()
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            int[] numberInt = new int[numbers.Length];

           

           


            string[,] digits =  {
    { " _ ", "| |", "|_|" }, // zero
    { "   ", "  |", "  |" }, // one
    { " _ ", " _|", "|_ " }, // two
    { " _ ", " _|", " _|" }, // three
    { "   ", "|_|", "  |" }, // four
    { " _ ", "|_ ", " _|" }, // five
    { " _ ", "|_ ", "|_|" }, // six
    { " _ ", "  |", "  |" }, // seven
    { " _ ", "|_|", "|_|" }, // eight
    { " _ ", "|_|", "  |" }  // nine
};


            for (int b = 0; b < 3; b++) {
                for (int a = 0; a < numbers.Length; a++)
                {

                    if (numbers[a] == '0') {

                        Console.Write(digits[0, b]);

                    }


                    if (numbers[a] == '1')
                    {

                        Console.Write(digits[1, b]);

                    }

                    if (numbers[a] == '2')
                    {

                        Console.Write(digits[2, b]);

                    }

                    if (numbers[a] =='3')
                    {

                        Console.Write(digits[3, b]);

                    }

                    if (numbers[a] == '4')
                    {

                        Console.Write(digits[4, b]);

                    }

                    if (numbers[a] == '5')
                    {

                        Console.Write(digits[5, b]);

                    }

                    if (numbers[a] == '6')
                    {

                        Console.Write(digits[6, b]);

                    }

                    if (numbers[a] == '7')
                    {

                        Console.Write(digits[7, b]);

                    }

                    if (numbers[a] == '8')
                    {

                        Console.Write(digits[8, b]);

                    }

                    if (numbers[a] == '9')
                    {

                        Console.Write(digits[9, b]);

                    }


                }
                Console.WriteLine();
            }
            



            

            Console.ReadLine();
        }
    }
}
