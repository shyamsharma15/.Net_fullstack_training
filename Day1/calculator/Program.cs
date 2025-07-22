
using System; //--> package name ,,,, using is a keyword to import namespaces (package)
namespace claculatorOperations // it is optional here you are declaring your own space ok, What you are going to declare then you have to define that into the namespace
{
    internal class Program // class name shoul be same as file name
    {
        static void Main(String[] args) // main is the entry point of our program
        {
            char ch = 'A';
            //string s = "Hello";
            Console.WriteLine("character is :" + ch); // Console is a pre defined class and WriteLine is a method
            Console.WriteLine("Equivelent number is : " + (byte)ch); //
            Console.WriteLine("min and max value of character :" + (int)char.MinValue +" "+ (int)char.MaxValue);//if we want the max and min value of character 
            Console.WriteLine("size of character is "+ sizeof(char));//if we want size then 
            Console.WriteLine("Welcome to the C# ");
            Console.WriteLine("This is my C# class");

            // taking user input 
            Console.WriteLine("enter the number 1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("The sum of these two number is " + sum);


            Console.ReadKey();//for hold on console screen

            /////practice problem
        //     Console.WriteLine("Enter coupon values upto 5 ");
        //     int[] arr = new int[7];
        //     for (int i = 0; i < 7; i++)
        //     {
        //         arr[i] = Convert.ToInt32(Console.ReadLine());
        //     }

        //     Console.WriteLine("Total value/price we collected is :- ");
        //     int sum = 0;
        //     int j = 0, k = 0, l = 0, max = -1, greaterIndex = -1;
        //     for (int i = 0; i < 7; i++)
        //     {


        //         sum += arr[i];

        //         if (arr[i] > max)
        //         {
        //             max = arr[i];
        //             greaterIndex = i;
        //         }

        //         if (arr[i] <= 50)
        //         {
        //             j++;
        //         }
        //         else if (arr[i] > 50 && arr[i] <= 100)
        //         {
        //             k++;
        //         }
        //         else
        //         {
        //             l++;
        //         }


        //     }

        //     Console.WriteLine("Total value collected   : " + sum);
        //     Console.WriteLine("Highest coupon redeemed :" + max + "(coupon #" + greaterIndex + ")");
        //     Console.WriteLine("Category breakdown:- ");
        //     Console.WriteLine("Small  (≤50)   : " + j);
        //     Console.WriteLine("Medium  (51-100)   : " + k);
        //     Console.WriteLine("Large  (>100)   : " + l);


         }


   }
}