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
        /**Since Animal was our Super Class ... using
            using the (:) symbol. We can use Animal as
            a wrapper for all of the Animal based classes.
            If we add anhy methods to Animal, they must exist
            in all of the child classes. i.e. Cat, Dog, Turtle 
        */
    }
}