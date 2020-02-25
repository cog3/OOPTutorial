using System;
public class Cat : Animal
{
    private string name;
    private int age;
    private bool isFemale;
    public Cat(string name, int age, bool isFemale)
    {
        this.name = name;
        this.age = age;
        this.isFemale = isFemale;
    }
}