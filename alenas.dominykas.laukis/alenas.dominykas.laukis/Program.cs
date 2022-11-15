// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

class GFG
{

    public static void prCharWithFreq(string s)
    {

        // Store all characters and
        // their frequencies in dictionary
        Dictionary<char, int> d = new Dictionary<char, int>();

        foreach (char i in s)
        {
            if (d.ContainsKey(i))
            {
                d[i]++;
            }
            else
            {
                d[i] = 1;
            }
        }

        // Print characters and their
        // frequencies in same order
        // of their appearance
        foreach (char i in s)
        {
            // Print only if this
            // character is not printed
            // before
            if (d[i] != 0)
            {
                Console.Write(i + d[i].ToString() + " ");
                d[i] = 0;
            }
        }
    }

    // Driver Code
    public static void Main(string[] args)
    {
        string s = "geeksforgeeks";
        prCharWithFreq(s);
    }
}
