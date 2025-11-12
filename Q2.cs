//Instruciton-
//11.Inheritance(Base Class): Create a base class called Vehicle with a Speed property and a Go() method that prints "Vehicle is moving."
//12.	Inheritance (Derived Class): Create a class called Car that inherits from Vehicle. Add a NumberOfDoors property to the Car class.
//13. base Keyword: Add a constructor to Car that takes speed and numberOfDoors. How do you pass the speed value to the base Vehicle constructor? (Hint: use base()).
//14.	Method Overriding (virtual): Mark the Go() method in the Vehicle class as virtual.
//15.Method Overriding(override): Now, override the Go() method in the Car class to print "Car is moving at [Speed] km/h."
//16.	Polymorphism: What is polymorphism? Write code that creates a List<Vehicle> and adds both a Vehicle object and a Car object to it. Loop through the list and call the Go() method on each object. What is the output?
//17.	Abstract Class: What is an abstract class? Change the Vehicle class to be abstract. What happens if you try to create an instance of Vehicle now?
//18.	Abstract Method: Add an abstract method to Vehicle called ShowFuelType(). What does this force you to do in the Car class? Implement it in Car to print "Car uses gasoline."
//19.	Interface: What is an interface? Create an interface called IDrivable with a single method signature: void Stop().
//20.Implementing an Interface: Make your Car class implement the IDrivable interface. Provide the required Stop() method implementation. Can a class inherit from multiple interfaces?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public abstract class Vehicle
    {
        public int speed { get; set; }
        public Vehicle(int speed)
        {
            this.speed = speed;
        }
        public virtual void Go()
        {
            Console.WriteLine("Vehicle is moving");
        }
        public abstract void ShowFuelType();
    }
    public class Car:Vehicle,IDrivable
    {
        public int NumberOfDoors { get; set; }
        public Car(int speed,int NumberOfDoors):base(speed)
        {
            this.NumberOfDoors = NumberOfDoors;
            
        }
        public override void Go()
        {
            Console.WriteLine($"Car is moving at {speed}");
        }
        public override void ShowFuelType()
        {
            Console.WriteLine("Car uses Gasoline");
        }
        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
