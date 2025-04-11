namespace Hangmanproject;
using System.Collections.Generic; //helps to run the lists
using System.IO; //helps to run file io

class Program
{
    static void Main(string[] args)
    {
        //Variables- these are the variables that i will use to store information in my game.
        string[] wordList = { }; //This will be a list of words that can be chosen from. It starts empty but will fill it from a file later.
        string chosenWord = ""; // This will keep the secret word that the player is trying to guess.
        List<char> guessedLetters = new List<char>(); //This will keep track of all the letters that the player has guessed so far.
        int incorrectGuesses = 0; //This will help to count how many times the player guesses wrong.
        int maxGuesses = 6; //This will help to set the limit on how many wrong guesses the player gets.
    }
        //This is the method that prints the hangman figure based on the number of wrong guesses. Therefore, i had to take help from ai about the hangman figure because i was unaware of the code to the figure..
        public static void printHangman(int Wrong)
    {
        if (Wrong == 0)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("  ===");
        }
        else if(Wrong == 1)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (Wrong == 2)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("|    |");//Body
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (Wrong == 3)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("/|    |");//Left arm
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (Wrong == 4)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("/|\\    |"); //Both arms
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (Wrong == 5)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("/|\\    |"); //Both arms
            Console.WriteLine("/    |");  //Left leg
            Console.WriteLine("   ===");
        }
        else if (Wrong == 6)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |"); //Head
            Console.WriteLine("/|\\    |");//Both arms
            Console.WriteLine("/ \\    |"); //both legs
            Console.WriteLine("   ===");
        }
    
    }
      //Methods - These are the functions that will perform specific actions in the game.
      string chooseWord(string[] wordList) //chooseWord () will randomly pick a word from the list of words.
    {
        Random random = new Random();
        int index = random.Next(wordList.Length);
        return wordList[index];
    }
     void displayWord(string word, List<char> guessedLetters)   //displayWord() will show the current word with the letters that the player has guessed correctly.
    {
        foreach (char letter in word)
        {
            if (guessedLetters.Contains(letter))
            {
                Console.Write(letter + "");
            }
            else
            {
                Console.Write("_ ");
            }
        }
        Console.WriteLine();
    }
    char guessLetter(List<char> guessedLetters) //guessLetter() will let the player make a guess and check if the guess is right or wrong.
    {
        Console.Write("Guess a letter: ");
        char guess = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (guessedLetters.Contains(guess))
        {
            Console.WriteLine("You have already guessed that letter.");
            return guessLetter(guessedLetters);  //calling back to get a new guess
        }
        guessedLetters.Add(guess);
        return guess;
    }
        
     
    
}


    


