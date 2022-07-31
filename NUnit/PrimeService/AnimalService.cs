using System;

namespace Prime.Services
{
    public abstract class Animal
    {
        public virtual string MakeSound()
        {
            Console.WriteLine("Animal gives a sound!");
            return "...";
        }
    }

    public class Dog : Animal
    {
        public override string MakeSound()
        {
            Console.WriteLine("Dog sounds like: woof woof !");
            return "woof woof";
        }
    }

    public class Cat : Animal
    {
        public override string MakeSound()
        {
            Console.WriteLine("Cat says: meow meow !");
            return "meow meow";
        }
    }
}
