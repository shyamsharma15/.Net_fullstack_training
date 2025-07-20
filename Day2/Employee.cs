class Employee
{
    public void Input()
    {
        Console.WriteLine("Enter the First Number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second Number ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Sum of these two number is " + (num1 + num2) );
    }

    public void Display()
    {
        Console.WriteLine("This is our Employee class");
    }
}