using System;
public class Turtle : Animal
{
    private string name;
    private int age;
    private string species;
    public Turtle(string name, int age, string species)
    {
        this.age = age;
        this.name = name;
        this.species = species;
    }
}