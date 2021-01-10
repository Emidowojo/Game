
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args) 
   {
        Random r =new Random ();
        int easy = r.Next(1, 10);
        int intermediate = r.Next (1, 20);
        int hard = r.Next (1, 50);
        bool win = false;
 
        do
        {
            Console.Write("Guess a number from 1 to 10: ");
           

            string s = Console.ReadLine();
 
 
 
 
 
            int i =int.Parse(s);
 
            if (i > easy)
            {
             Console.WriteLine("Try guessing lower?...");
            }
            else if (i < easy)
            {
                Console.WriteLine("Try guessing higher?...");
            }
            else if (i == easy)
            {
                Console.WriteLine("Nicee...You won!");
                win = true;
            }
            Console.WriteLine();
        } while (win == false);
 
         
 
        Console.WriteLine("Thank you for playing!");

        do
        {

        

         Console.Write("Guess a number from 1 to 20: ");

          string s = Console.ReadLine();
 
 
 
 
 
            int i =int.Parse(s);
 
            if (i > easy)
            {
             Console.WriteLine("Try guessing lower?...");
            }
            else if (i < easy)
            {
                Console.WriteLine("Try guessing higher?...");
            }
            else if (i == easy)
            {
                Console.WriteLine("Nicee...You won!");
                win = true;
            }
            Console.WriteLine();
        } while (win == false);
 
         
 
        Console.WriteLine("Thank you for playing!");
            

            do{

              Console.Write("Guess a number from 1 to 50: ");


              string s = Console.ReadLine();
 
 
 
 
 
            int i =int.Parse(s);
 
            if (i > easy)
            {
             Console.WriteLine("Try guessing lower?...");
            }
            else if (i < easy)
            {
                Console.WriteLine("Try guessing higher?...");
            }
            else if (i == easy)
            {
                Console.WriteLine("Nicee...You won!");
                win = true;
            }
            Console.WriteLine();
        } while (win == false);
 
         
 
        Console.WriteLine("Thank you for playing!");
            

            }
        }
   }

    
