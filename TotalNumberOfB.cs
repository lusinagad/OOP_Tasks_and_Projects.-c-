using System;

public class MainClass
{
    public static int TotalNumberOfLetters (string number)
    {
        int count = 0;
    for ( int i = 0;i <number.Length;i++)
    {
        if (number[i] == 'b')
          {
             count ++;
          }
    }
    return count;
    }   
    public static void Main()
    { 
       string FirstString = Console.ReadLine();
        string SecondString = Console.ReadLine();
        
        Console.WriteLine(TotalNumberOfLetters (FirstString) + TotalNumberOfLetters (SecondString));
        
    }
}
