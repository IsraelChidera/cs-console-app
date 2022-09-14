// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {           
        
            // Write a guessing game where the user has to guess a secret number. 
            // After every guess the program tells the user whether their number 
            // was too large or too small. At the end the number of tries needed 
            // should be printed. It counts only as one try if they input the same
            //  number multiple times consecutively.
            GuessNumbers();            

        }        

    
        static void GuessNumbers(){   
            // getting random guess number   
            Random random = new Random();
            int correctNumber = random.Next(0,10);     

            // getting random number of tries
            int count = 0;
            int countNumber = random.Next(1,10);            

            // using a while loop
            // to loop through your guess
            // and using a conditional statement to know 
            // if it is correct or not
            while(count<countNumber){                
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello, please guess a number between 0 and 10");
                Console.ResetColor();
                string guessNumber = Console.ReadLine();

                try{
                    int guess = Convert.ToInt32(guessNumber);
                    count =  count + 1;
                    // Console.WriteLine("count" + count);
                    Console.WriteLine("guessed number" + guess);

                    if(guess == correctNumber){
                        Console.WriteLine("Congratulations, You guessed correctly!");
                        Console.WriteLine("Number of tries: " + count);
                        break;
                    }

                    else if(guess < correctNumber){
                        Console.WriteLine("You guessed LOWER, try again!"); 
                        continue;
                    }

                    else if(guess > correctNumber){
                        Console.WriteLine("You guessed HIGHER, try again!"); 
                        continue;
                    }
                }           
                catch(FormatException) {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }      
            }
            
            // if number of tries is exceeded
            if(count>=countNumber){
                Console.WriteLine("You have exceeded the number of tries");
                Console.WriteLine("The correct guess is : " + correctNumber);
            }
           
            
        }
    }
}
