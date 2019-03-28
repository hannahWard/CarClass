using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Car
    {
        public float gasLevel { get; set; }


        static Car()
        {
            float startingGasLevel = new Random().Next(1, 13);
        }

        public float AddGas(float startingGasLevel)
        {
            float newGasLevel = gasLevel + startingGasLevel;

            return newGasLevel;
        }

        public static float FillUp(float newGasLevel)
        {
            float amountOfGasAddedToFillUp = 13 - newGasLevel;

            return amountOfGasAddedToFillUp;
        }

    }
}
