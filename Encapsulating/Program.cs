using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new Team("sfdjhasvf");
        for (int i = 0; i < lines; i++)
        {
            try
            {

                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2],CultureInfo.InvariantCulture),
                    double.Parse(cmdArgs[3]));

                persons.AddPlayers(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }

        Console.WriteLine($"First team have {persons.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {persons.ReserveTeam.Count} players"); 



    }

}

