using System;
public class Animal
{
    Animal[] listOfAnimals = new Animal[3];
    public Animal[] setListOfAnimals()
    {
        Animal cindy = new Turtle("cindy", 6, "foo");
        Animal rooster = new Cat("rooster", 12, true);
        Animal chappy = new Dog("chappy", "husky", 4);
        listOfAnimals[0] = cindy;
        listOfAnimals[1] = rooster;
        listOfAnimals[2] = chappy;
        return listOfAnimals;
        //totally legal
    }
}