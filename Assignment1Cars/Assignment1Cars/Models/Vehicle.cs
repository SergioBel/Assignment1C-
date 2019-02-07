using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This calss contains
 * all the variables that each vehicle will contain
 */
public class Vehicle
{
    Guid VehicleID;
    string Make;
    string Model;
    int Year;
    int NumberOfWheels;
    int NumberOfDoors;

    public Vehicle(string Makem, string Modelm, int Yearm, int NumberOfWheelsm, int NumberOfDoorsm)
    {
        VehicleID = Guid.NewGuid();
        Make = Makem;
        Model = Modelm;
        Year = Yearm;
        NumberOfWheels = NumberOfWheelsm;
        NumberOfDoors = NumberOfDoorsm;
    }
    /// <summary>
    /// A string representation of a Vehicle
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return  $"Make: {Make} \n" +
            $"Model: {Model}\n" +
            $"Year: {Year}\n" +
            $"NumberOfWheels: {NumberOfWheels}\n" +
            $"NumberOfDoors: {NumberOfDoors} \n" +
            $"----------------------------------------------";
    }
}
