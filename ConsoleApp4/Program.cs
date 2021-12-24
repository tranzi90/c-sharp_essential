using System;

namespace SimpleRecords
{
    public record Passport(string FirstName, string LastName);
    //{
    //    public Passport(string firstName, string lastName) =>
    //        (FirstName, LastName) = (firstName, lastName);
    //    public string FirstName { get; init; }
    //    public string LastName { get; init; }
    //}
    class Program
    {
        static void Main()
        {
            Passport passport1 = new("Pierre", "Curie"); 
            Console.WriteLine(passport1); 

            Passport passport2 = new("Maria", "Skłodowska"); 
            Console.WriteLine(passport2);

            string newLastName = passport2.LastName + "-" + passport1.LastName;
            Passport passport3 = passport2 with { LastName = newLastName };
            Console.WriteLine(passport3);
        }
    }
}
