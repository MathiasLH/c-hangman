using System;
using System.Text.RegularExpressions;
using System.Collections;

class GameLogic
{
    private Stack guessedLetters = new Stack();
    private String[] displayWord, letterArray;
    private int lettersLeft, numberOfLives;

    public GameLogic(String playWord)
    {
        Console.WriteLine("playword is: " + playWord);

        letterArray = new string[playWord.Length];
        char[] charArr = playWord.ToCharArray();
        for (int i = 0; i < playWord.Length; i++)
        {
            letterArray[i] = charArr[i].ToString();
        }

        displayWord = new String[playWord.Length];
        lettersLeft = playWord.Length;

        for (int i = 0; i < displayWord.Length; i++)
        {
            displayWord[i] = "*";
        };
        numberOfLives = 5;
    }

    public void resetGame(String playWord)
    {
        Console.WriteLine("playword is: " + playWord);

        letterArray = new string[playWord.Length];
        char[] charArr = playWord.ToCharArray();
        for (int i = 0; i < playWord.Length; i++)
        {
            letterArray[i] = charArr[i].ToString();
        }

        displayWord = new String[playWord.Length];
        lettersLeft = playWord.Length;

        for (int i = 0; i < displayWord.Length; i++)
        {
            displayWord[i] = "*";
        };
        numberOfLives = 5;
    }

    //returns 0 if letter is incorrect format, 1 if letter already guessed, 2 if letter is accepted as guess, 3 if letter is wrong. 
    public Int32 guessLetter(String input)
    {
        input = input.ToLower();
        if (!checkRegex(input))
        {
            return 0;
        }

        //if letter is in the letterarray or not already guessed
        if (Array.IndexOf(letterArray, input) > -1 && !(guessedLetters.Contains(input)))
        {
            guessedLetters.Push(input);
            updateDisplayWord(input);
            Console.WriteLine("letter in the word!");
            return 2;
        }
        //if the letter is already guessed
        else if (guessedLetters.Contains(input))
        {
            Console.WriteLine("letter guessed already!");
            return 1;
        }
        //if the letter is just wrong
        else
        {
            guessedLetters.Push(input);
            Console.WriteLine("letter wrong!");
            numberOfLives--;
            return 3;
        }
    }

    private bool checkRegex(String letter)
    {
        int langInt=Globals.language;
        switch (langInt)
        {
            case 0:
                Regex _regex = new Regex(@"([a-z æ ø å])");
                break;
            case 1:
                Regex _regex = new Regex(@"([a-z])");
                break;
            case 2:
                Regex _regex = new Regex(@"([a-z ö ü ä])");
                break;
            default:
                Console.WriteLine("Language Default Hit");
                break;
        }
        Regex _regex = new Regex(@"[^ 0 - 9]");
        //check if letter is correct format
        Match match = _regex.Match(letter);
        if (match.Success)
        {
            return true;
        }
        return false;
    }

    //returns 0 for still playing, 1 if player lost, 2 if player won.
    public Int32 checkPlayerStatus()
    {
        if (numberOfLives == 0)
        {
            Console.WriteLine("player lost!");
            return 1;
        }
        else if (lettersLeft == 0)
        {
            Console.WriteLine("player won!");
            return 2;
        }
        return 0;
    }

    //Handles updating the displayword and deleting deleting 
    private void updateDisplayWord(String letter)
    {
        for (int i = 0; i < letterArray.Length; i++)
        {
            String tempChar = letterArray[i];
            if (tempChar == letter)
            {
                displayWord.SetValue(letter, i);
                lettersLeft--;
            }
        }
    }
    public String getDisplayWord()
    {
        String returnString = "";
        for (int i = 0; i < displayWord.Length; i++)
        {
            returnString += displayWord[i];
        }
        return returnString;
    }
}


