using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


public class ParkingInterval
{
    private ParkingSpot parkingSpot;
    public ParkingSpot ParkingSpot
    {
        get { return parkingSpot; }
        private set { parkingSpot = value; }
    }
    private string registrationPlate;
    public string RegistrationPlate
    {
        get { return registrationPlate; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Registration plate can’t be null or empty!");
            }
            registrationPlate = value;
        }
    }
    private int hoursParked;
    public int HoursParked
    {
        get { return hoursParked; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Hours parked can’t be zero or negative!");
            }
            hoursParked = value;
        }
    }
    private double revenue;

    public double Revenue
    {
        get
        {
            if (parkingSpot is SubscriptionParkingSpot)
            {
                return 0;
            }
            return parkingSpot.Price * hoursParked;
        }        
    }

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }
    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return parkingSpot.ParkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> ParkingSpot #{ParkingSpot.Id}");
        sb.AppendLine($"> RegistrationPlate: {RegistrationPlate}");
        sb.AppendLine($"> HoursParked: {HoursParked} hours");
        sb.AppendLine($"> Revenue: {Revenue:f2} BGN");

        return sb.ToString().Trim();
    }
}

