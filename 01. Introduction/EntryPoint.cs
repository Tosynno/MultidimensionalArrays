using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        int years = 10;
        int months = 12;
        int days = 31;
        int hours = 24;

        List<int[,,]> temperatures = new List<int[,,]>();

        for (int year = 0; year < years; year++)
        {
            temperatures.Add(new int[months, days, hours]);

            for (int month = 0; month < temperatures[year].GetLength(0); month++)
            {
                for (int day = 0; day < temperatures[year].GetLength(1); day++)
                {
                    for (int hour = 0; hour < temperatures[year].GetLength(2); hour++)
                    {
                        if (month >= 0 && month <= 2)
                        {
                            Console.WriteLine($"temperatures is {temperatures[year][month, day, hour] = rng.Next(-10, 15)}");
                        }
                        else if (month >= 3 && month <= 5)
                        {
                            Console.WriteLine($"temperatures is {temperatures[year][month, day, hour] = rng.Next(15, 25)}");
                        }
                        else if (month >= 6 && month <= 8)
                        {
                            Console.WriteLine($"temperatures is {temperatures[year][month, day, hour] = rng.Next(25, 35)}");
                        }
                        else if (month >= 9 && month <= 11)
                        {
                            Console.WriteLine($"temperatures is {temperatures[year][month, day, hour] = rng.Next(0, 25)}");
                        }
                    }
                }
            }
        }

       
    }
}
