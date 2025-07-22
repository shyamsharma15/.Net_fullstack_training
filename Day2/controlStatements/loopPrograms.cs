class LoopProgram
{


    static void Main()
    {
        //Syntax of for loop
           // initialization or the starting point ,
           // condition to check wether it has reached to the end point   
           // increment   
        for(int i= 0 ;i<=5 ; i++)
        {
            Console.WriteLine("the value of i is : " + i);
        }
        
        //Syntax of while loop
        int x=0;
        while(x<5)
        {
            Console.WriteLine("The value of x is :" + x);
            x++;
        }

        //Syntax of do While Loop
        int y=5;
        do
        {
            Console.WriteLine("Even if condition is fail the program will execute once");
            y++;

        }
        while(y<1);
    //
      // To use for each loop in case of arrays/collection

      //In an array reference type of variable it's holding multiple values
      string[] names = {"Niti" ,"Jatin","Preeti"};
      Console.WriteLine("Element at first index is "+names[0]);
      //the iteration will do automatically by setting the starting point and ending point
      foreach(string name in names)
      {
        Console.WriteLine(name);
      }


      // Array is of fixed size
      int[] arr = new arr[4]; // here the size of array is fixed

      int[] scores = {20,21,22}; // here is dynamic allocation

        // Array is fast in searching , static in nature

        // Matrix
        int[,] mat = new int[2, 3]; // means 2 rows , 3 columns



    }
}


