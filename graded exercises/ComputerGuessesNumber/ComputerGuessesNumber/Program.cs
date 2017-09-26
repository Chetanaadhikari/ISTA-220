using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGuessesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 to 100 that you would like the computer to guess: ");
            int userpickednumber = int.Parse(Console.ReadLine());
            int lowernumber = 0;
            int highernumber = 100;

            int computerguess = (lowernumber + highernumber) / 2;
            

            while (computerguess != userpickednumber)
            {
                

                if (computerguess > userpickednumber)
                {

                    
                    int Highernumber = highernumber;

                    computerguess = (0 + Highernumber / 2);
                    Console.WriteLine("The number " + computerguess + " is too high. Guess again");
                    Console.ReadLine();
                    Highernumber = computerguess;

                }

                else if (computerguess < userpickednumber)
                {
                    int Lowernumber = lowernumber;
                    computerguess = (100 + Lowernumber) / 2;
                    Console.WriteLine("The number " + computerguess + "is too low, Guess again");
                    Console.ReadLine();
                    Lowernumber = computerguess;

                }

                else if (computerguess == userpickednumber)
                { Console.WriteLine("Good Job computer. You have guessed " + computerguess + "which is the correct number!");
                    Console.ReadLine();
                }

            }  
            
        }
    }
}
