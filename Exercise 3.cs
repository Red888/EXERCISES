using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
       for (int i = 5; i > 0; i--) ///reset again the number
		{
 
            for (int y = i; y > 0; y--) 
             {
                    Console.Write("*");
             }
      		 Console.WriteLine(" ");
        }
	}
    
    

}