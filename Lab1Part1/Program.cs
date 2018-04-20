using System;

namespace Lab1_Part1
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                string var1 = "";
                string var2 = "";
                int firstInt;
                int secondInt;

                while (true)
                {
                    Console.WriteLine("Enter a 3 digit number");//user inputs 1st 3 digit number
                    var1 = Console.ReadLine();
                    Console.WriteLine("Enter a second 3 digit number"); //user inputs 2nd 3 digit numbers
                    var2 = Console.ReadLine();
                    if (var1.Length == 3 && int.TryParse(var1, out firstInt) && var2.Length == 3 && int.TryParse(var2, out secondInt))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again!");
                    }
                }
                Task(var1, var2);
                
                bool input = Continue();
                if (input == false)
                {
                    break;
                }
            }
            Console.WriteLine("Goodbye");
        }
        public static void Task(string input1, string input2)
        {
            string[] Number1Array = new string[3];
            string[] Number2Array = new string[3];
            int[] myintArray1 = new int[Number1Array.Length];
            int[] myintArray2 = new int[Number2Array.Length];


            for (int i = 0; i < 3; i++)
            {
                Number1Array[i] += input1[i];
                myintArray1[i] = Convert.ToInt32(Number1Array[i].ToString());
                Number2Array[i] += input2[i];
                myintArray2[i] = Convert.ToInt32(Number2Array[i].ToString());

            }

            int sum1 = myintArray1[0] + myintArray2[0];
            int sum2 = myintArray1[1] + myintArray2[1];
            int sum3 = myintArray1[2] + myintArray2[2];

            if ((sum1 == sum2) && (sum1 == sum3))
            {
                Console.WriteLine("The conditions are True");
            }

            else
            {
                Console.WriteLine("The conditions are False");
            }
        }
        public static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? Y/N");
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
    }
}
