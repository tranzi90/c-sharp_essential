using System;

namespace AnimalWorld
{
    abstract class Animal
    {
        protected abstract string Name { get; }
        public abstract void MakeSound();
        public void Run(Animal animal) => Console.WriteLine($"The {animal.Name} is running.");
    }
    class Dog : Animal
    {
        protected override string Name => nameof(Dog);
        public override void MakeSound() => Console.WriteLine("Woof-Woof");
        public void BringStick() => Console.WriteLine("Bring a stick");
    }
    sealed class Cat : Animal
    {
        protected override string Name => nameof(Cat);
        public override void MakeSound() => Console.WriteLine("Meow-Meow");
        public void CatchMouse() => Console.WriteLine("Catch the mouse");
    }
    //class DomesticCat : Cat
    //{
    //}
    class Program
    {
        static void Main()
        {


            #region Null & Dog
            //Animal animal = null;
            //Animal myDog = new Dog(); 
            #endregion

            #region Reflection
            //Type type = Type.GetType("AnimalWorld.Dog");
            //Animal animal = Activator.CreateInstance(type) as Animal;
            //animal?.Run(new Dog()); 
            #endregion
        }
    }
}
