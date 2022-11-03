using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

public class Program
{
    static void Main()
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        Task5();
        //Task6();
        //Task7();
        //Task8();
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
            while (n > 0)                         // adding counter to the general sum 
            {                                                                 // and decrementing it by 1 each iteration
                sum += n--;
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
        byte[] arr = new byte[] { 3, 5, 9, 8, 15 };               // initialisation of array
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

    private static void Task5()
    {
        string[] arr = new string[10];                             // initialisation of array
        string s = "hello";
        for (byte i = 0; i < 10; i++)
           
        {
            arr[i] = Console.ReadLine();                           // input of array elements from console
            if (arr[i].ToLower() == "hello")                        // determine if 'Hello' was entered
            {
                Console.WriteLine("Labas!");
                break;                                             // end the cycle if 'Hello' was entered
            }
            if (i == 9)                                            // output if 'Hello' was not entered
            { Console.WriteLine("'Hello' was not entered but Labas anyway :)"); }
        }
    }

    private static void Task6()
    {
        int[] arr = new int[10];                                      // initialisation of array
        Console.WriteLine("Vvedite chisla");
        for (byte i = 0; i < 10; i++)
        {
            string s = Console.ReadLine();                           // user enters a number
            bool isNumeric = int.TryParse(s, out arr[i]);            // parsing the entered value into numeric variable
            if ((!isNumeric))                                        // checking that a number was entered
            {
                Console.WriteLine("Invalid input data");             // display error message and break if string was enered
                break;
            }
            if (i == 9)                                              // calculating sum of the the first and the last one elements if 'break' did not work
            {
                Console.WriteLine("Summa pervogo i poslednego elementov ravna " + (arr[0] + arr[9]));
            }
        }

    }

    private static void Task7()
    {
        int[] arr = new int[10];                                      // initialisation of array
        Console.WriteLine("Vvedite chisla");
        int max;
        int min;
        byte max_i;
        byte min_i;
        string s = Console.ReadLine();                           // user enters a number
        bool isNumeric = int.TryParse(s, out arr[0]);            // parsing the entered value into numeric variable
        if ((!isNumeric))                                        // checking that a number was entered
        {
            Console.WriteLine("Invalid input data");  
            
        }
        else
        {
            max = arr[0]; min = arr[0]; max_i = 0; min_i = 0;   // initial values of min, min_i, max, max_i variables
            for (byte i = 1; i < 10; i++)
            {
                s = Console.ReadLine();                           // user enters a number
                isNumeric = int.TryParse(s, out arr[i]);            // parsing the entered value into numeric variable
                if ((!isNumeric))                                        // checking that a number was entered
                {
                    Console.WriteLine("Invalid input data");             // display error message and break if string was enered
                    break;
                }
                if (arr[i] > max) { max = arr[i]; max_i = i; }           // finding max value
                if (arr[i] < min) { min = arr[i]; min_i = i; }           // finding min value
                if (i == 9) { Console.WriteLine("Otvet: " + (max_i + min_i)); }
            }
        }
    }

    private static void Task8()
    {
        int[] arr = new int[10];                                      // initialisation of array
        Console.WriteLine("Vvedite chisla");                          // ask user to enter a number
        for (byte i = 0; i < 10; i++)
        {
            string s = Console.ReadLine();                          // user enters a number
            bool isNumeric = int.TryParse(s, out arr[i]);            // parsing the entered value into numeric variable
            if (!isNumeric)
            {                                                              // checking that a positiv number was entered
                Console.WriteLine("Invalid input data");
                break;                                        // display error message if invalid data was enered
            }
        }
        for (byte k = 0; k < 10; k++)
        {
            for (byte j = 0; j < 9 - k; j++)
            {
                if (arr[j + 1] < arr[j])                         //И ОПЯТЬ НЕ РАБОТАЕТ
                {
                    int c = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = c;
                }
            }
        }
        Console.WriteLine("*****************");
        Console.WriteLine("***** Otvet *****");
        foreach (int k in arr)
        {
            Console.WriteLine(k);
        }
    }




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