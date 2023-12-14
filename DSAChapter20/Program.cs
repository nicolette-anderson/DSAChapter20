
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Program
{
    static void Main() {
        //setup
        List<Person> BasketballPlayers = new List<Person>()
    {
        new Person(){FirstName = "Jill", LastName = "Huang" , Team="Gators"},
        new Person(){FirstName = "Janko", LastName = "Barton" , Team="Sharks"},
        new Person(){FirstName = "Wanda", LastName = "Vakulskas" , Team="Sharks"},
        new Person(){FirstName = "Jill", LastName = "Moloney" , Team="Gators"},
        new Person(){FirstName = "Luuk", LastName = "Watkins" , Team="Gators"}
    };
        List<Person> BaseballPlayers = new List<Person>()
    {
        new Person() { FirstName = "Hanzla", LastName = "Radosti", Team = "32ers" },
        new Person() { FirstName = "Tina", LastName = "Watkins", Team = "Barleycorns" },
        new Person() { FirstName = "Alex", LastName = "Patel", Team = "Sharks" },
        new Person() { FirstName = "Jill", LastName = "Huang", Team = "Barleycorns" },
        new Person() { FirstName = "Wanda", LastName = "Vakulskas", Team = "Barleycorns" }
    };

        //make a dictionary with the first and last names as a full name, team doesn't matter for comparison
        Dictionary<string, string> FullNames = new Dictionary<string, string>();
        Dictionary<string, string> DuplicateNames = new Dictionary<string, string>();
    }

    void ExtractNames(List<Person> players, Dictionary<string, string> FullNames, Dictionary<string, string> DuplicateNames)
    {
        foreach (Person p in players)
            {
            if (!FullNames.ContainsKey(p.FirstName) && !FullNames.ContainsValue(p.LastName))
            {
                FullNames.Add(p.FirstName, p.LastName);
            }
            else
            {
                DuplicateNames.Add(p.FirstName, p.LastName);
            }
        }
    }
    //call the method here on both lists, print list of names in both lists.
}

public class Person
{
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string Team { get; set; } 
}
