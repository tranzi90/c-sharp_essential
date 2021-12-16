using System;

namespace Birds
{
    class Bird { public virtual void Fly(string name) => Console.WriteLine($"{name}: Fly"); }
    class Canary : Bird { }
    class Ostrich : Bird { public /*new*/ override void Fly(string name) => Console.WriteLine($"{name}: Not fly"); }
    class Program
    {
        static void Main()
        {
            Bird[] birds = { new Canary(), new Ostrich() };

            for (int i = 0; i < birds.Length; i++)
                birds[i].Fly(birds[i].ToString());

            //Bird bird = new Canary();
            //bird.Fly(nameof(Canary));
            //bird = new Ostrich();
            //bird.Fly(nameof(Ostrich));

            //Canary canary = new();
            //canary.Fly(nameof(Canary));
            //Ostrich ostrich = new();
            //ostrich.Fly(nameof(Ostrich));
        }
    }
}
