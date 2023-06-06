using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {	
    	int index = 0;
        string pattern = "+--";  
       for (int i = 0; i <10; i++) 
		{
                     Console.Write(pattern[index]);
                     index++;
                     
                     if(index > 2){ // or pattern.Lenght -1
                     
                     index = 0;
                     
                     }
                     
                     
        }
     }

}