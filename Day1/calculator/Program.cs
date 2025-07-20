
using System; //--> package name
namespace claculatorOperations // it is optional here you are declaring your own space ok, What you are going to declare then you have to define that into the namespace
{
    internal class Program // class name shoul be same as file name
    {
        static void Main(String[] args) // main is the entry point of our program
        {
            char ch = 'A';
            //string s = "Hello";
            Console.WriteLine("character is :" + ch);
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
      }
   }
}