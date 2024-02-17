using System;
using System.Collections.Generic;
using System.Text;
using Zadacha02.Model;
using Zadacha02.Views;

namespace Zadacha02.Controllers
{
    public class CalculatePrice
    {
        private Transport transport;
        private Display display;

        public CalculatePrice()
        {
            display = new Display();
            transport = new Transport(display.Kilometers, display.Time);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowCheapestWayToTravel();
        }
    }
}
