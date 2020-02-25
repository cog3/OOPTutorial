using System;
public class Dog : Animal
{
    private string name;
    private int age;
    private string breed;
    public Dog(string name, string breed, int age)
    {
        this.name = name;
        this.age = age;
        this.breed = breed;
    }
}