using System;

namespace InClassExerciseOOP
{
    // used multiple classes
    class Program
    {
        static void Main(string[] args)
        {
            // created multiple objects - audi , bmw

            Car audi = new Car();
            Car bmw = new Car();
            Console.WriteLine(audi.color);
            Console.WriteLine(audi.maxSpeed);
            Console.WriteLine(bmw.color);
            Console.WriteLine(bmw.maxSpeed);
        }
    }

    //Created a Class Car
    class Car
    {
        //class members
        //created a variable(property) color , maxspeed
        public string color = "red"; // field
        public int maxSpeed = 200;   // field

        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
