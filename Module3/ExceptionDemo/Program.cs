/*
Author: Phoenix Vu
Date: 10/18/2025
Assignment: PA3, Task 2
*/
namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetInt(5);
                //The line below is for testing other kinds of errors.
                //Console.WriteLine(args[4]);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("dude you're dividing by 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred.");
            }
        }

        static int GetInt(int x)
        {
            return (x/0); //Intentional divide by 0 error method
        }
    }
}
