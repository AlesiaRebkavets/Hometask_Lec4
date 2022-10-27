using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

public class Program
{
    static void Main()
    {
        //Task1();
        //Task2();
        Task3();
        //Task4();




        //Task9();
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

       private static void Task2()
       {
        byte i = 1;
        while (i <= 10)                                          // do the operetions untill counter is less than 10
        {
            Console.WriteLine("3 * " + i + " = " + (3 * i));     // multiply three by counter and output the value
            i++;                                                 // increment the counter
        }
       }

       private static void Task3() 
       {
        byte[] arr = new byte[5] {3, 5, 9, 8, 15 };               // initialisation of array
        short m = 1;
        foreach (byte b in arr)                                   // multiply each array element by variable with initial value equal to '1'
        {
            m *= b;
        }
        Console.WriteLine("Otvet: " + m);                         // output of the calculated value
    }

       private static void Task4()
       {
        short a = 2048;                                            // initialisation of variables
        short i = 0;
        while (a >= 10)                                            // divide a by 2 when a >= 10 and increment counter
        {
            a /= 2;
            i++;
        }
        Console.WriteLine("Otvet: " + i);                          // output of the calculated value
    }

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

       private static void Task9()
       {
        byte[] arr = new byte[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};        // initialisation of array

        for (int i = 1; i<=10; i++) {
            foreach (byte b in arr)                                       // all array elements are multiplied by a value of counter from the first cycle
            {
                Console.WriteLine(i + " * " + b + " = " + (i * b));       // output of the calculated value
            }
            if (i < 10)                                                   // added a delimiter for all the tables except the last one
            {
                Console.WriteLine("***********");                        
            }
            else break;           
        }

       }

}