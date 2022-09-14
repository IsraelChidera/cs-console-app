// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a program that prints the next 20 leap years.
               LeapYears();
                                
        }

        

        static void LeapYears(){
            // last leap year
            int lastLeapYear = 2020;

            // looping through for the next 20 years
           for(int i=0; i<20; i++){
            Console.WriteLine($"Leap Year: {lastLeapYear=lastLeapYear+4}");            
           }   
        }
    
        
    }
}
