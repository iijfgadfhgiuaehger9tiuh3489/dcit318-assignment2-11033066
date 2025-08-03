using System;

namespace InterfaceApp
{
    // Interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    public class Car : IMovable
    {
        private string brand;

        public Car(string brand)
        {
            this.brand = brand;
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public string GetBrand()
        {
            return brand;
        }
    }

    // Class Bicycle implementing IMovable
    public class Bicycle : IMovable
    {
        private string type;

        public Bicycle(string type)
        {
            this.type = type;
        }

        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }

        public string GetType()
        {
            return type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===");
            Console.WriteLine();

            // Create instances of Car and Bicycle
            Car car = new Car("Toyota");
            Bicycle bicycle = new Bicycle("Mountain Bike");

            // Call Move() method on each instance
            Console.WriteLine($"{car.GetBrand()} car:");
            car.Move();

            Console.WriteLine($"\n{bicycle.GetType()}:");
            bicycle.Move();

            // Demonstrate polymorphism with interfaces
            Console.WriteLine("\n=== Polymorphism with Interface ===");
            IMovable[] movableObjects = { new Car("Honda"), new Bicycle("Road Bike"), new Car("Ford") };

            for (int i = 0; i < movableObjects.Length; i++)
            {
                Console.Write($"Movable object {i + 1}: ");
                movableObjects[i].Move();
            }

            // Additional interface demonstration
            Console.WriteLine("\n=== Interface Reference Demo ===");
            IMovable movableCar = new Car("BMW");
            IMovable movableBike = new Bicycle("Electric Bike");

            Console.WriteLine("Using interface references:");
            movableCar.Move();
            movableBike.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
