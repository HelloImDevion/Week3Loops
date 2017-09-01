using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int lives = 5;
            //int magicNumber = 88;
            //bool isPlaying = true;

            //while(lives > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess My Lucky Number!!");
            //    int userGuess = int.Parse(Console.ReadLine());
            //    if (magicNumber == userGuess)

            //    {
            //        Console.WriteLine("\a Congrats you guessed right!!!");
            //        //break;
            //        isPlaying = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry Try again");
            //        lives--;
            //        Console.WriteLine("You have: " + lives + " Lives Left");
            //    }
            //}

            //print out the numbers 1 - 100
            //if the number is a multiple of 3 print fizz 
            // if the number is a multiple of 5 print buzz
            // if the number is a multiple of both fizzbuzz

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");

            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");

            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Create an int array with 10 elements
            //find the mean of these elements and output the result to the console

            //int[] array = { 10, 90, 2, 3, 4, 5, 6, 7, 8, 8 };
            //int total = 0;

            //foreach (int number in array)
            //{
            //    total += number;
            //}

            //int mean = total / array.Length;

            //Console.WriteLine(mean);

            // NESTED LOOPS

            //for (int i = 1; i <= 2; i++)
            //{
            //    for (int j = 1; j <= 4; j++)
            //    {
            //        Console.Write(j); // Colums 
            //    }
            //    Console.WriteLine(); // Row
            //}

            //print A Triangle 
            //int n = 4;

            //for (int row = 1; row <= n ; row++)
            //{
            //    for(int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int n = 5;

            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= n; col++)
            //    {
            //        Console.Write("{1} x {0} ", col, row);
            //    }
            //    Console.WriteLine();
            //}

            //string[] movies = { "Friday", "Transformers", "Paranormal Activity", "ATL", "Takers", "Unstoppable", "The founder" };

            //foreach (string movie in movies)
            //{
            //    if (movie.StartsWith("A") || movie.StartsWith("E") || movie.StartsWith("O") || movie.StartsWith("I") || movie.StartsWith("U") ) 
            //    {

            //    }
            //   else
            //    {
            //        Console.WriteLine(movie);
            //    }

            //}

            //Console.WriteLine("Enter a Number: ");
            //int userNumber = int.Parse(Console.ReadLine());

            //while (userNumber % 3 !=  0)
            //{
            //    Console.WriteLine("Try again!");
            //    userNumber = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You Won!");

            Console.WriteLine("Enter your first Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number: ");
            int m = int.Parse(Console.ReadLine());

            while(n > m)
            {
                Console.WriteLine("(Your second number has to be bigger than your first) Enter Your First Number: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number: ");
                m = int.Parse(Console.ReadLine());
                
            }


            for (int total = n; total < m; total++)
            {
                if(total % 3 == 0)
                {
                    Console.WriteLine(total);
                }
            }
            Console.WriteLine();



        }
    }
}
