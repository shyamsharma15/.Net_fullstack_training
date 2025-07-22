using System;
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static int Count;

    public Employee()
    {
        Count++;
        Console.WriteLine("The value of count is " + Count);
        Name = "Jatin";
        Age = 23;
    }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //static constructor will run only once not as per the object
    static Employee()
    {
        Count++;
        Console.WriteLine("The value of count is " + Count);
    }


    public void Display()
    {
        Console.WriteLine("Name of Employee is " + Name + "Age of Employee is " + Age);
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee("shyam", 22);
        Employee e3 = new Employee();

        e1.Display();
        e2.Display();
        e3.Display();
    }
}