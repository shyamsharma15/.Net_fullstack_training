/*method overriding -- where some methods in base class and in inherited or child class are with the same name
run time  binding -- when compiler will identify which method
needs to be called at run time when the object will be created

Method override in Polymorphism can be done using virtual and override keyword
*/

/*
// Example 1 :- here no method is overriden

public class Person
{

    public void GetRole()
    {

        Console.WriteLine("Person class");

    }

}

public class Teacher : Person
{

    //Generally it's overriden but you are hiding that method in the inherited class
    public  void GetRole()
    {

        Console.WriteLine("She is a teacher");

    }

}

public class Mother : Person
{

    //Generally it's overriden but you are hiding that method in the inherited class
    public  void GetRole()
    {

        Console.WriteLine("She is a Mother");

    }

}

public class MainProgram
{

    static void Main()
    {
        //Late Binding - RunTime Polymorphism
        Person p = new Teacher();
        Person p1 = new Mother();

        p.GetRole();
        p1.GetRole();
    }
}
*/
// both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide


//Example 2:- 
/*so here in this example actual mai overriding ho rhi hai with the help of virtual and override keyword because hum 
//yahan main function mai reference liya hai parent class ka lekin object banaya hai usse child class ka aur method jo
//hum call kar rhae hai wo donno mai same hai lekin child walli method call hogi wahi hum chahte thae parent waali nhi
// toh agar hum yea virtual aur override keyword nhi lagate toh as usual wo parent class mai jaake wo method call karega 
jo ki actual method overiding ka example nhi hai */


// public class Father
// {
//     public virtual void Identity()
//     {
//         Console.WriteLine("The Aadhaar no of father is 246434 ");
//     }


// }

// public class Child : Father
// {

//     public override void Identity()
//     {
//         Console.WriteLine("The Aadhaar no of Child is 12345");
//     }

// }

// public class MainProgram
// {
//     static void Main()
//     {
//         Father f = new Child();
//         f.Identity();
//     }
// }