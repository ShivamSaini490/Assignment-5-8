using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        try
        {
            SomeMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in Main: " + ex.Message);
        }

        Console.WriteLine("Program continues...");
    }

    static void SomeMethod()
    {
        try
        {
            DivideByZero();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in SomeMethod: " + ex.Message);
            throw;
        }
    }

    static void DivideByZero()
    {
        int numerator = 58;
        int denominator = 0;

        int result = numerator / denominator;
    }
}
