using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha07
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();
    }
}
