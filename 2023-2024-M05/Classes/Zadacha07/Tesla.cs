﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha07
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Batteries { get; private set; }

        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Batteries} Batteries\n{this.Start()}\n{this.Stop()}";
        }
    }
}
