using System;

namespace ThreeClasses
{
    public class Apartment : Domicile
        {
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
}