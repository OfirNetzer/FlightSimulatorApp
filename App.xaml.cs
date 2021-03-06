﻿using FlightSimulatorApp.Model;
using FlightSimulatorApp.ViewModel;
using FlightSimulatorApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightSimulatorApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        //public FlightViewModel flightVM;
        private MyFlightModel model;
        public MapViewModel MapVM;
        //private SlidersViewModel slidersVM;
        public DashboardViewModel dashboardVM;
        public ControllersViewModel controllersVM;
        public ConnectionAndErrorVIewModel connectNErrorVM;

        private void Application_Startup(Object sender, StartupEventArgs e)
        {
            model = new MyFlightModel(new MyTelnetClient());
            //flightVM = new FlightViewModel(model);
            MapVM = new MapViewModel(model);
            dashboardVM = new DashboardViewModel(model);
            controllersVM = new ControllersViewModel(model);
            connectNErrorVM = new ConnectionAndErrorVIewModel(model);

            Window mainWindow = new MainWindow();
            mainWindow.Show();
            //model.Connect("127.0.0.1", 5402);
            //model.Start();
        }


        //internal object flightSimulatorViewModel;
        //internal object MainViewModel;
        //private MyFlightModel model;

        //private void Application_Startup(Object sender, StartupEventArgs e)
        //{
        //    model = new MyFlightModel(new MyTelnetClient());

        //    MainVM = new MainViewModel(model);
        //    model.connect("127.0.0.1", 5402);
        //    model.start();
        //    Window mainWindow = new MainWindow();
        //    mainWindow.Show();
        //}
        //private MapViewModel MapVM { get => MapVM; set => MapVM = value; }
        ////private SlidersViewModel slidersVM;
        //private DashboardViewModel dashboardVM { get => dashboardVM; set => dashboardVM = value; }
        //private ControllersViewModel controllersVM { get => controllersVM; set => controllersVM = value; }
        //private MyFlightModel model;

    }
}