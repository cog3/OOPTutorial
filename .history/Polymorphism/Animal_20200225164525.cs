using System;
public class Animal
{
    Animal[] listOfAnimals = new Animal[3];
    public Animal[] setListOfAnimals()
    {
        Animal cindy = new Turtle();
        Animal rooster = new Cat();
        Animal chappy = new Dog();
        listOfAnimals[0] = cindy;
        listOfAnimals[1] = rooster;
        listOfAnimals[2] = chappy;
    }
}