using System;

namespace ThreeClasses
{
    public class Car : Vehicle
    {
        public Car(int year, string make, string model)
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
}