using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            //2. Write a C# program to check whether a number is divisible by 5 and 11 or not
            Console.WriteLine("2.>number is divisible by 5 and 11 or not");
            int div=456;
            if(div%5==0 && div % 11 == 0)
            {
                Console.WriteLine(div+" is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine(div+" is not divisible by 5 and 11");
            }

            //3. Write a C# program to find maximum between three numbers
            Console.WriteLine("3.>maximum between three numbers");
            int a = 569486;
            int b = 562634;
            int c = 564971;
            if(a>=b && a >= c)
            {
                Console.WriteLine(a + " is the maximum number");
            }
            else if(b>=a && b >= c)
            {
                Console.WriteLine(b + " is the maximum number");
            }
            else
            {
                Console.WriteLine(c + " is the maximum number");
            }
            //4. Write a C# program to input any alphabet and check whether it is vowel or consonant
            Console.WriteLine("4.>vowel or consonant");
            char alpha = 'h';
            if(alpha == 'a'|| alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u')
            {
                Console.WriteLine(alpha + " is Vowel");
            }
            else
            {
                Console.WriteLine(alpha + " is consonant");
            }

            //5. Write a C# program to create Simple Calculator 
            Console.WriteLine("5.>Simple Calculator");
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine("Addition = " + sum);
            int sub = number1 - number2;
            Console.WriteLine("Subtraction = " + sub);
            int divs = number1 / number2;
            Console.WriteLine("Division = " + divs);
            int mul = number1 *number2;
            Console.WriteLine("Addition = " + mul);


            //6. Write a C# program to check whether a number is negative, positive or zero
            Console.WriteLine("6.>negative, positive or zero");
            int num = 4898865;
            if (num > 0)
            {
                Console.WriteLine(num+" is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine(num+" is negative");
            }
            else
            {
                Console.WriteLine(num+" is zero");
            }

            //7. Write a C# program to input any character and check whether it is alphabet, digit or special character 
            Console.WriteLine("7.>alphabet, digit or special character");
            char ch = 'm';
            if(ch>='a' && ch<='z'|| ch>='A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is alphabet");
            }
            else if (ch >= 0 )
            {
                Console.WriteLine(ch + " is digit");
            }
            else
            {
                Console.WriteLine(ch + " is special character");
            }

            //8. Write a C# program to check whether a number is even or odd
            Console.WriteLine("8.>number is even or odd");
            int num2 = 456884;
            if (num2 % 2 == 0)
            {
                Console.WriteLine(num2 + " is even");
            }
            else
            {
                Console.WriteLine(num2 + " is odd");
            }
        }
        //1. Write a C# program to check whether a year is leap year or not  
        
        

          
          
          


        

        //9. Write a C# program print total number of days in a month
       
        
        //10. Write a C# program to input basic salary of an employee and calculate its  
        //Gross salary according to following: Basic Salary <= 10000 : HRA = 20%, DA = 80% Basic Salary <= 20000 : HRA = 25%, 
        //DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95% 



    }
}
