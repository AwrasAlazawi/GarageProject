using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class UI
    {
        public void MainMenu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Enter Capcity Of Garage");
                Console.WriteLine("1) Park Vehicle");
                Console.WriteLine("2) UnPark Vehicle");
                Console.WriteLine("0) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddVehicle();
                        break;
                    case "2":
                        UnParkVehicle();
                        break;
                    case "3":
                        //  UnParkVehicle();
                        break;
                    case "4":
                        //  UnParkVehicle();
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
                Console.Write("\n<PRESS ANY BUTTON TO CONTINUE>");
                Console.ReadKey();


                 void AddVehicle()
                {
                    Garage<Vehicle> theGarage =
                         new Garage<Vehicle>(50);

                    theGarage.ParkVehicle(new Vehicle(1, "Blue", 4));
                    theGarage.ParkVehicle(new Car(5, "Black", 4, 3));
                    theGarage.ParkVehicle(new Bus(6, "Red", 8, "diesel"));
                    theGarage.ParkVehicle(new Car(10, "Pink", 4, 3));
                    theGarage.ParkVehicle(new Bus(8, "Green", 8, "diesel"));
                    theGarage.ParkVehicle(new Motorcycle(3, "white", 2, 34));


                    var filterdGarage = theGarage.
                        Where(x => x.NoOfWheels > 2 ||
                        x.Color == "Red").
                        OrderBy(x => x.RegNo);
                      

                    foreach (Vehicle a in theGarage)
                    {
                         Console.WriteLine(a.RegNo + " is " +
                             a.RegNo + "Color " + a.Color + " No of Wheels " +
                             a.NoOfWheels);

                       
                    }
                   
                }

                void UnParkVehicle()
                {

                    
                    AddVehicle();

                    Console.WriteLine("If You want to unpark vehicle,");
                    Console.WriteLine("Please, Enter Registartion no of Vehicle");
                    string inputNoasstring = Console.ReadLine();
                    int inputNo;
                    int.TryParse(inputNoasstring, out inputNo);

                    Garage<Vehicle> theGarage =
                         new Garage<Vehicle>(50);

                    var filterdGarage = from x in theGarage.
                       Where( > 2 ).
                       OrderBy(x => x.RegNo);
                    // theGarage.UnParkVehicle(inputNo);

                    foreach (Vehicle a in theGarage)
                    {
                        Console.WriteLine(a.RegNo + " is " +
                            a.RegNo + "Color " + a.Color + " No of Wheels " +
                            a.NoOfWheels);


                    }

                }
            }


        }
    }
}
