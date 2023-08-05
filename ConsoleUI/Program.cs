using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Vehicles

            var vehicles = new List<Vehicle>();


            var car1 = new Car
            {
                HasTrunk = true,
                Year = "2021",
                Make = "Toyota",
                Model = "Camry",
            };
            vehicles.Add(car1);

            var motorcycle1 = new Motorcycle
            {
                HasSideCart = true,
                Year = "2021",
                Make = "Kawasaki",
                Model = "Ninja",
            };
            vehicles.Add(motorcycle1);

            Vehicle vehicle1 = new Car
            {
                Make = "Ford",
                Year = "1955",
                Model = "Mustang"
            };
            vehicles.Add(vehicle1);
            {

                Vehicle vehicle2 = new Motorcycle
                {
                    Make = "Harley Davidson",
                    Year = "2021",
                    Model = "Fat Boy",
                };
                vehicles.Add(vehicle2);



                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"Year:{vehicle.Year}");
                    Console.WriteLine($"Make:{vehicle.Make}");
                    Console.WriteLine($"Model:{vehicle.Model}");
                    Console.WriteLine();
                    Console.WriteLine();
                }


                #endregion

            }
        }
    }
}




















