using System;
public class Human
{
    private boolean ownerOfCat;
    private Cat whiskers = new Cat();
    public getCat()
    {
        this.ownerOfCat = true;
    }
    public feedCat()
    {
        if (ownerOfCat)
        {
            whiskers.feedCat();
        }
    }
    public playWithCat()
    {
        if (ownerOfCat)
        {
            whiskers.play();
        }
    }
    public sleepCat()
    {
        if (ownerOfCat)
        {
            whiskers.sleep();
        }
    }
    public makeCatMeow()
    {
        return whiskers.meow(); //THIS WILL HAVE AN ERROR .. YOU CANNOT TELL A CAT TO MEOW
    }

}