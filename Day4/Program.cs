using System;

class Program
{
    static void Main()
    {
        string text = "Csharp Language";
        int l = text.Length;
        Console.WriteLine("The length of string is " + l);

        string subString = text.Substring(7, 8);
        Console.WriteLine("THe text of string is " + subString);

        Console.WriteLine(text.ToUpper());

        Console.WriteLine(text.ToLower());

        string newString = text.Replace("Csharp", "Java");
        Console.WriteLine("Replaced text string is :" + newString);

        String replaced = text.Replace(" ", "");
        Console.WriteLine("text without space is : " + replaced);

        Console.WriteLine(text.IndexOf("uage"));



        int pos = text.IndexOf("Language");
        string newText = text.Substring(pos, 8);
        Console.WriteLine("New Text Value " + newText.ToUpper());

        string data = "CSharp,Language";
        String[] lang = data.Split(',');
        foreach (string valuess in lang)
        {
            Console.WriteLine(valuess);
        }




        // questions are :-
        //Count all the blank space
        //Count all the special characters
        //Count the words in a sentence

        // string data1 = "This is a day four of our training class";
        // string[] lang1 = data1.Split(' ');
        // Console.WriteLine("the blank spaces in above string is :" + (lang1.Length - 1));

        // string data2 = "This,is,a,day,four";

        // create a string using constructor , using literals,using concatenation,using a property or method


        /// Practice questions for strings 
        //Count all the blank space
        //Count all the special characters
        //Count the words in a sentence


        string data1 = "This is the day four training class";
        string[] lang1 = data1.Split(' ');
        Console.WriteLine("The blank spaces in the above statement : " + ((lang1.Length) - 1));

        string data2 = "apple,orange,grapes,banana";
        string[] lang2 = data2.Split(',');
        Console.WriteLine("The Specail characters in the above statement : " + ((lang2.Length) - 1));

        string data3 = "This is the day four training class";
        string[] lang3 = data3.Split(' ');
        Console.WriteLine("The Number of Words in the above statement :" + (lang3.Length));


        int specialCharCount = 0;
        foreach (char c in text)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                specialCharCount++;
        }
        Console.WriteLine("Total number of special characters: " + specialCharCount);


        string s = Console.ReadLine();
        int vowel = 0;
        foreach (char ch in s)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                vowel++;
            }
        }
        Console.WriteLine("total vowel count :" + vowel);





    }
}