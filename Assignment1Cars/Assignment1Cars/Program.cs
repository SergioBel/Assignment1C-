using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment1Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomeVariableWeDontWant();
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * We introduce 20 different type of cars
             * and introduce all the characterstics
             * Add them into the List
            */
            vehicles.Add(new Vehicle(Makem: "Seat", Modelm: "Ibiza", Yearm: 2010, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Ford", Modelm: "F350", Yearm: 2009, NumberOfWheelsm: 6, NumberOfDoorsm: 2));
            vehicles.Add(new Vehicle(Makem: "Toyota", Modelm: "Prius", Yearm: 2004, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Chevrolet", Modelm: "Avalanche", Yearm: 2012, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Honda", Modelm: "Civic", Yearm: 2007, NumberOfWheelsm: 4, NumberOfDoorsm: 2));
            vehicles.Add(new Vehicle(Makem: "Mitsubishi", Modelm: "Eclipse", Yearm: 2014, NumberOfWheelsm: 4, NumberOfDoorsm: 2));
            vehicles.Add(new Vehicle(Makem: "Porsche", Modelm: "911", Yearm: 1994, NumberOfWheelsm: 4, NumberOfDoorsm: 2));
            vehicles.Add(new Vehicle(Makem: "Kia", Modelm: "Sportage", Yearm: 2008, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Nissan", Modelm: "Juke", Yearm: 2017, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Volkswagen", Modelm: "Tiguan", Yearm: 2015, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Opel", Modelm: "Astra", Yearm: 2015, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Citroen", Modelm: "C3", Yearm: 2012, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "GMC", Modelm: "Terrain", Yearm: 2016, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Lincoln", Modelm: "Aviator", Yearm: 2019, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Tesla", Modelm: "ModelX", Yearm: 2014, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Audi", Modelm: "Q5", Yearm: 2011, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Mercedes", Modelm: "C230", Yearm: 2013, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Land-Rover", Modelm: "Land-Rover", Yearm: 2008, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Jeep", Modelm: "Patriot", Yearm: 2015, NumberOfWheelsm: 4, NumberOfDoorsm: 4));
            vehicles.Add(new Vehicle(Makem: "Dodge", Modelm: "Challenger", Yearm: 2005, NumberOfWheelsm: 4, NumberOfDoorsm: 2));

            foreach (var vehicle in vehicles)
            {
                WriteLine(vehicle.ToString());
            }

        }




        //Console.Write/WriteLine
        //Console.ReadKey/ReadLine;
    }
}
