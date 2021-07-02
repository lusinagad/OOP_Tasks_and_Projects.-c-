using System;

public class MainClass
{
    public static int SumRange(int x, int y)
    {
        int sum = 0;
       
        for (int i = x;i<=y;i++)
        {  
            sum+=i;
        }
        
        return sum;
    }
    public static void Main()
    {
        //  use a function and find sum of  numbers A to B, B to C and their sum 
         int A = Convert.ToInt32(Console.ReadLine());       
         int B = Convert.ToInt32(Console.ReadLine()); 
         int C = Convert.ToInt32(Console.ReadLine()); 
          int SumAB = (SumRange(A,B)+SumRange(B,C));
       
        
        Console.WriteLine(SumAB);
              
    }
}
