using System;

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

    public override string ToString()
    {
        return $"{FullVehicle}";
    }
}
