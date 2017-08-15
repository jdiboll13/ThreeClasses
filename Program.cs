using System;

namespace ThreeClasses
{
    class Program
    {
        public class Apartment
        {
            public int NumberOfBedrooms { get; set; }
            public int NumberOfBathrooms { get; set; }
            public int SquareFootage { get; set; }
            public int Level { get; set; }
            public Apartment(int bedrooms, int bathrooms, int level, int sqft)
            {
                NumberOfBedrooms = bedrooms;
                NumberOfBathrooms = bathrooms;
                SquareFootage = sqft;
                Level = level;
            }

            public override string ToString()
            {
                return $"This spacious {SquareFootage}ft apartment is located on level {Level}, it comes with {NumberOfBedrooms} bedrooms and {NumberOfBathrooms} bathrooms.";
            }
        }
        public class Pets
        {
            public string Name { get; set; }
            public string Breed { get; set; }
            public bool IsFat { get; set; }

            public Pets(string name, string breed)
            {
                Name = name;
                Breed = breed;
            }
        }
        public class Vehicle
        {
            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }

            public Vehicle(int year, string make, string model)
            {
                Year = year;
                Make = make;
                Model = model;
            }
            public override string ToString()
            {
                return $"I have a {Year} {Make} {Model}.";
            }

        }
        static void Main(string[] args)
        {
            var home = new Apartment(2, 2, 1800, 2);

            Console.WriteLine(home);

            var cat1 = new Pets("Frank", "Orange Tabby");

            Console.WriteLine($"{cat1.Name} is an {cat1.Breed}.");

            var cat2 = new Pets("Piper", "Calico");

            Console.WriteLine($"{cat2.Name} is an {cat2.Breed}.");

            var car = new Vehicle(2005, "Ford", "Mustang");

            Console.WriteLine(car);
        }
    }
}
