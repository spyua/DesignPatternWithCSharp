﻿using System;

namespace Observer.Observer
{
    public class Computer : IPressureMonitorObserver
    {
        public void OnPressureChanged(double pressure)
        {
            Console.WriteLine($"PC is notified that the air pressure has changed: {pressure}");
        }
    }
}
