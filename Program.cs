using System;

namespace CsharpBasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            //Common Practice 
             
            Console.WriteLine("Welcome to Systems Limited");
            Console.Write("Learning DotNet");
            long num1 = 1234567890123456789;
            int num2 = 15;
            Console.WriteLine(num1+num2);
            Console.WriteLine(num1 +num2 + "What is this:" );

            

           // Division Operator:
            int varTest1 = 30;
            int varTest2 = 9;
            int division = varTest1 / varTest2;
            Console.WriteLine("Division = " + division);


            // Modulus Operator:
            int varTest11 = 30;
            int varTest22 = 7;
            int modulus = varTest11 % varTest22;
            Console.WriteLine("Modulus = " + modulus);



            // Get valuses from user and utilize them:

            Console.WriteLine("Enter First Number = ");
            int FirstNum = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter Second Number = ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int SumNum = FirstNum + SecondNum;
            Console.WriteLine("What do you want to see");
            string msg = Console.ReadLine();

            Console.WriteLine(msg + SumNum);

            

            //String Operations

            string message1 = "Hello, How are you ?";
            string message2 = "I'm fine";
            Console.WriteLine("What is sting length = " + message1.Length);
            Console.WriteLine("String in Upper case: " + message1.ToUpper());
            Console.WriteLine("String in Lower case: " + message2.ToLower());
            Console.WriteLine("Concatenation of String" + string.Concat(message1, message2));
            Console.WriteLine("Checking letter Index : " + message1[6]);
            int FindIndex;
            Console.WriteLine("Checking Index of letter  : " + (FindIndex = message1.IndexOf("a")));

            Console.WriteLine("Substring : " + message1.Substring(FindIndex));

            


            // if else condition

            Console.WriteLine("Write a number = ");
            int GetNum = Convert.ToInt32 (Console.ReadLine());

            if (GetNum > 20)
            {
                Console.WriteLine("Provided Number is greater than 20");
            }
            else if (GetNum < 20)
            {
                Console.WriteLine("Provided Number is less than 20");

            }
            else if (GetNum ==20)
            {
                Console.WriteLine("Provided Number is equal to 20");

            }
            else
            {
                Console.WriteLine("Provided Number is incorrect");

            }

            // Single line if else condition

            int a = 10, b = 15;
            string ShowResult = (a < b) ? "A is less than B" : "A is greater than B";
            Console.WriteLine("Result: " + ShowResult);

            

            // while loop

            int num = 1;
            while(num <5)
            {
                Console.WriteLine("The Number is :" + num);
                num++;
            }

            Console.WriteLine("LOOP completed");

           
        }
    }
}
