using System;

public class MainClass
{
    static int SumofDigitsFunction(int number)
    {
        int count = 0;
        while(number>0)
        {
            count+=number%10;
            number=number/10;
        }
        return count;  
    }     
    public static void Main()
    {
       int FirstNumber = SumofDigitsFunction(Convert.ToInt32(Console.ReadLine()));
        int SecondNumber = SumofDigitsFunction(Convert.ToInt32(Console.ReadLine()));
        if (FirstNumber>SecondNumber) 
        {
            Console.WriteLine("1");
        }
          if (SecondNumber>FirstNumber) 
            {
               Console.WriteLine("2");
            }
           if (FirstNumber == SecondNumber) 
            {
            Console.WriteLine("0");
        }
            
    }
}
