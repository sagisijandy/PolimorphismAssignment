
using System;

namespace IQuittable

{ 
    public interface IQuittable 
    {
        void Quit();
    }

     static void Main(string[] args)
    {
        // Instantiate an Employee object
        Employee employee = new Employee()
        {
            FirstName = "John",
            LastName = "Doe",
            Id = 1234
        };

        // Create an object of type IQuittable using polymorphism and call the Quit() method on it
        IQuittable quittableEmployee = employee;
        quittableEmployee.Quit();

        Console.ReadLine();
    }
}






