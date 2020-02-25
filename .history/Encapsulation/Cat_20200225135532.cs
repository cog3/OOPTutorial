using System;

namespace Cat
{
    public class Cat
    {
        private int mood = 0;
        private int hunger = 0;
        private int energy = 0;
        private string meow = "MEOW!";

        public sleep()
        {
            energy++;
            hunger++;
        }
        public feed()
        {
            hunger--;
            mood++;
            meow();
        }
        public play()
        {
            mood++;
            energy--;
            hunger--;
            meow();
        }
        private meow()
        {
            return meow;
        }

    }
}