using System;

namespace ThreeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var home = new Apartment(2, 2, 1800, 2);

            Console.WriteLine(home);

            var cat = new Cat("Frank", "Orange Tabby");

            Console.WriteLine($"{cat.Name} is an {cat.Breed}.");

            var dog = new Dog("Piper", "Calico");

            Console.WriteLine($"{dog.Name} is an {dog.Breed}.");

            var car = new Car(2005, "Ford", "Mustang");

            Console.WriteLine(car);
        }
    }
}
