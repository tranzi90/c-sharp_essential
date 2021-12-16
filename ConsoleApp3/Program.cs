using System;

namespace Virtual
{
    // Существуют таксы 3-х разных размеров:
    // 1. кроличья    — высота в холке 10-15 см
    // 2. карликовая  — высота в холке 14-21 см
    // 3. стандартная — высота в холке 20-27 см
    class Taksa // Такса по-английски - dachshund.
    {
        public void ShowSize() => Console.WriteLine("Taksa 10-27 см");
    }
    class StandardTaksa : Taksa
    {
        public void ShowSize() => Console.WriteLine("Standard Taksa 20-27 см");
    }
    class Program
    {
        static void Main()
        {
            Taksa taxa = new StandardTaksa();
            taxa.ShowSize();

            //Taksa taxa = new Taksa();
            //taxa.ShowSize();
            //taxa = new StandardTaksa();
            //taxa.ShowSize();

            //{
            //    void q(Taksa taksa) => taksa.ShowSize();
            //    Taksa x = new Taksa();
            //    q(x);
            //    StandardTaksa y = new StandardTaksa();
            //    q(y);
            //}
            //Console.WriteLine(new string('-', 15));
            //{
            //    Taksa x = new Taksa();
            //    x.ShowSize();
            //    Taksa y = new StandardTaksa();
            //    y.ShowSize();
            //}

            //Taksa x = new Taksa();
            //x.ShowSize();
            //StandardTaksa y = new StandardTaksa();
            //y.ShowSize();
        }
    }
}
