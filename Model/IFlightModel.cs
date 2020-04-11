﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp.Model
{
    interface IFlightModel
    {
        event PropertyChangedEventHandler PropertyChanged;
        void NotifyPropertyChanged(string propName);

        double Throttle { get; set; }
        double Aileron { get; set; }
        double Elevator { get; set; }
        double Rudder { get; set; }
        double Latitude { get; set; }
        double Longtitude { get; set; }
        double Air_Speed { get; set; }
        double Altitude { get; set; }
        double Roll { get; set; }
        double Pitch { get; set; }
        double Altimeter { get; set; }
        double Heading { get; set; }
        double Ground_Speed { get; set; }
        double Vertical_Speed { get; set; }


        //connection to the simulator
        void connect(string ip, int port);
        void disconnect();
        void start();
    }
}