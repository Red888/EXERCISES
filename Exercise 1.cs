using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
       for (int i = 0; i <=4; i++) ///reset again the number
		{
 
            for (int y = 0; y <= i; y++) 
             {
                    Console.Write("*");
             }
      		 Console.WriteLine(" ");
        }
	}

}