using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

public class Program
{
    static void Main()
    {
        Task1();
    }
    private static void Task1()
    {
        Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
        string s = Console.ReadLine();                          // user enters a number
        bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
        {
            int sum = 0;                                        
            for (int i = n; i > 0; i--)                         // adding counter to the general sum 
            {                                                                 // and decrementing it by 1 each iteration
                sum += i;
            }
            Console.WriteLine("Otvet raven " + sum);            // output of the calculated value
        }
        else                                                    
        {
            Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
        }
    }

    //   private static void Task2()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task3()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task4()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task5()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task6()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task7()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task8()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

    //   private static void Task9()
    //   {
    //   Console.WriteLine("Vvedite chislo");                    // ask user to enter a number
    //       string s = Console.ReadLine();                          // user enters a number
    //   bool isNumeric = int.TryParse(s, out int n);            // parsing the entered value into numeric variable
    //        if ((isNumeric) && (n >= 0))                            // checking that a positiv number was entered
    //       {

    //       }
    //       else                                                    
    //       {
    //           Console.WriteLine("Invalid input data");            // display error message if invalid data was enered
    //       }
    //   }

}