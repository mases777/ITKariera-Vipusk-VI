using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ParkingSpot
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private bool occupied;
    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }
    private string type;
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            price = value;
        }
    }
    protected List<ParkingInterval> parkingIntervals;

    public List<ParkingInterval> ParkingIntervals
    {
        get { return parkingIntervals; }        
    }

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        Id = id;
        Occupied = occupied;
        Type = type;
        Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }
    public bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (Occupied || Type != type)
        {
            return false;
        }
        ParkingInterval parkingInterval = new ParkingInterval(this, registrationPlate, hoursParked);
        parkingIntervals.Add(parkingInterval);
        occupied = true;
        return true;
    }
    public double CalculateTotal()
    {
        return parkingIntervals.Sum(x => x.Revenue);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.AppendLine($"> Price per hour: {Price:f2} BGN");

        return sb.ToString().Trim();

    }
}

