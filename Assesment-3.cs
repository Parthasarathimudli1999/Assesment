using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Vehicles
    {
        class Vehicle
        {
            protected string make;
            protected string model;
            protected string year;

            public Vehicle()
            {
            }
            public Vehicle(string make, string model, string year)
            {
                this.make = make;
                this.model = model;
                this.year = year;
            }

            public string Make
            {
                set { make = value; }
                get { return make; }
            }
            public string Model
            {
                set { model = value; }
                get { return model; }
            }
            public string Year
            {
                set { year = value; }
                get { return year; }
            }

            public void Accelerate()
            {
            }
            public void Decelerate()
            {
            }
            public void Drive()
            {
            }
            public void Start()
            {
            }
            public void Stop()
            {
            }
        }
        class Car : Vehicle
        {

        }
        class Van : Vehicle
        {

        }

        class ExcursionVan : Van
        {
        }

        class Minivan : Van
        {
            protected bool cargo_Net;
            protected bool dual_Sliding_Doors;

            public Minivan()
            {
            }
            public Minivan(bool cargo_Net, bool dual_Sliding_Doors)
            {
                this.cargo_Net = cargo_Net;
                this.dual_Sliding_Doors = dual_Sliding_Doors;
            }

            public void SetCargoNet(bool cargo_Net)
            {
                this.cargo_Net = cargo_Net;
            }
            public void SetDualSlidingDoors(bool dual_Sliding_Doors)
            {
                this.dual_Sliding_Doors = dual_Sliding_Doors;
            }

            public bool HasCargoNet()
            {
                return cargo_Net;
            }
            public bool HasDualSlidingDoors()
            {
                return dual_Sliding_Doors;
            }
        }


        class Sportscar : Car
        {

        }

        class TestVehicles
        {
            static void Main()
            {
                Car myCar = new Car();
                myCar.Drive();

                Sportscar mySportsCar = new Sportscar();
                mySportsCar.Drive();

                Van myVan = new Van();
                myVan.Drive();

                Minivan myMiniVan = new Minivan();
                myMiniVan.Drive();

                ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();
            }
        }
    }
 
