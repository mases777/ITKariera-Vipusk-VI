using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha02.Model
{
    public class Transport
    {
		private int kilometers;

		public int Kilometers
		{
			get { return kilometers; }
			set { kilometers = value; }
		}
		private string time;

		public string Time
		{
			get { return time; }
			set { time = value; }
		}
		private double startPrice;

		public double StartPrice
		{
			get { return startPrice; }
			set { startPrice = value; }
		}

        public Transport(int kilometers, string time)
        {
            Kilometers = kilometers;
            Time = time;
        }
        public Transport() : this(0, "")
        {
            
        }

		public double CalculateCheapest()
		{
			double pricePerKm = 0;
			if (kilometers < 20)
			{
				startPrice = 0.7;
				if (time == "day")
					pricePerKm = 0.79;
				else
					pricePerKm = 0.9;
			}
			else if (kilometers < 100)
			{
				startPrice = 0;
				pricePerKm = 0.09;
			}
			else
			{
                startPrice = 0;
                pricePerKm = 0.06;
            }
			return pricePerKm;
		}

		public double CalculatePrice()
		{
			return CalculateCheapest() * kilometers + startPrice;
		}

    }
}
