﻿using System.Linq;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }

    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public override string ToString() => $"{Name} {LastName}";
}