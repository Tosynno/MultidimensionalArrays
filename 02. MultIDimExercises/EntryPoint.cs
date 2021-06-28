using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        string[,] people = new string[2, 4];
        string[] person = new string[4];
        string input = string.Empty;

        for (int i = 0; i < people.GetLength(0); i++)
        {
            Console.WriteLine("Please input your information in the following format \"Firstname, Lastname, Age, City\":");
            input = Console.ReadLine();

            person = input.Split(new string[] { ", " }, StringSplitOptions.None);

            for (int j = 0; j < people.GetLength(1); j++)
            {
                people[i, j] = person[j];
            }
        }

        for (int i = 0; i < people.GetLength(0); i++)
        {
            for (int j = 0; j < people.GetLength(1); j++)
            {
                Console.Write($"{people[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}