// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

public class Letter
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }

    public static List<Letter> ReturnLettersCount(string fileName)
    {
        string text;
        List<Letter> letters = new List<Letter>();

        using (StreamReader sr = new StreamReader(fileName))
        {
            text = sr.ReadToEnd().ToLower();
        }

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                Letter letter = letters.Find((letter) => letter.Symbol == c);
                if (letter == null)
                {
                    letters.Add(new Letter() { Symbol = c, Frequency = 1 });
                }
                else
                {
                    letter.Frequency++;
                }
            }
        }

        return letters;
    }

    static void Main(string[] args)
    {
        string fileName = @"C:\demo\data.txt";

        List<Letter> letters = ReturnLettersCount(fileName);


        foreach (Letter letter in letters)
        {
          
            Console.Write(letter.Frequency);
            Console.Write(letter.Symbol);

        }

    }
}
