using System;
using System.Collections.Generic;
using System.Linq;

namespace weaponsReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>
            {
                new Soldier("Joseph", 24, "M1", "Major"),
                new Soldier("Ronald", 31, "Minigun", "Corporal"),
                new Soldier("Stephan", 76, "Desert Eagle", "Captain"),
                new Soldier("Andrew", 12, "Kalashnikov", "Sergeant"),
                new Soldier("Kianoo", 135, "Rocket", "General")
            };

            var newSoldiers = soldiers.Select(soldier => new
            {
                Name = soldier.Name,
                Title = soldier.Title
            });

            foreach (var soldier in newSoldiers) 
            {
                Console.WriteLine($"Имя:{soldier.Name} Звание:{soldier.Title}");
            }

            Console.ReadLine();
        }
    }
}

class Soldier
{
    private string _weapon;
    private int _tour;

    public Soldier(string name, int tour, string weapon, string title)
    {
        _weapon = weapon;
        _tour = tour;
        Name = name;
        Title = title;
    }

    public string Name { get; private set; }
    public string Title { get; private set; }
}
