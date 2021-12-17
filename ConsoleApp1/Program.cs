using System;

namespace Interfaces
{
    interface IBreather { abstract void Breathe(); }
    interface IMoving { void Move(); }
    abstract class Animal : IBreather, IMoving
    {
        public abstract void Breathe();
        public abstract void Move();
    }
    abstract class Bird : Animal { }
    class Canary : Bird
    {
        public override void Breathe() => Console.WriteLine("Canary.Breathe");
        public override void Move() => Console.WriteLine("Canary.Move");
    }
    class Ostrich : Bird
    {
        public override void Breathe() => Console.WriteLine("Ostrich.Breathe");
        public override void Move() => Console.WriteLine("Ostrich.Move");
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
