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
                Console.WriteLine("\t\t\tEnter Capcity Of Garage");
                Console.WriteLine("\t\t\t========================");
                Console.WriteLine("Bus , Car, Motocycle\n");
                Console.WriteLine("1) Park Vehicle");
                Console.WriteLine("2) List Vehicle");
                Console.WriteLine("3) UnPark Vehicle");
                Console.WriteLine("4) Search vehicle by Color");
                Console.WriteLine("0) Exit");

                try
                {
                  string input = Console.ReadLine();

                
                Garage<Vehicle> theGarage =
                            new Garage<Vehicle>(50);
                switch (input)
                {
                    case "1":
                        AddVehicle();
                        break;
                    case "2":
                        ListVehicle();
                        break;
                    case "3":
                        UnParkVehicle();
                        break;
                        case "4":
                            SearchByColor();
                            break;
                        case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }

               //Console.Write("\n <PRESS ANY BUTTON TO CONTINUE>");
               // Console.ReadKey();


                void ListVehicle()
                {
                    foreach (Vehicle a in theGarage)
                    {
                        Console.WriteLine(a);
                    }
                }

                void AddVehicle()
                {
                        Console.WriteLine("How many Capacity of Grage:");
                        int capcity = int.Parse(Console.ReadLine());
                        int regno, noWheels, noOfEng, cylinderV, cap;
                    string color, fuelType;
                    /*theGarage.ParkVehicle(new Vehicle(1, "Blue", 4));
                theGarage.ParkVehicle(new Car(5, "Black", 4, 3));
                theGarage.ParkVehicle(new Bus(6, "Red", 8, "diesel"));
                theGarage.ParkVehicle(new Car(10, "Pink", 4, 3));
                theGarage.ParkVehicle(new Bus(8, "Green", 8, "diesel"));
                theGarage.ParkVehicle(new Motorcycle(3, "white", 2, 34));*/

                    //Console.WriteLine("How many Vehicle you want to do park:");
                    //  cap = int.Parse(Console.ReadLine());
                    for (int i = 0; i < capcity; i++)
                    {
                        Console.WriteLine("Enter type of Vehicle");
                        string typeOfV = Console.ReadLine();

                       switch (typeOfV)
                        {
                            case "Car":
                                Console.WriteLine("Enter registration no ");
                                regno = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter color of car");
                                color = Console.ReadLine();
                                Console.WriteLine("how many wheels ");
                                noWheels = int.Parse(Console.ReadLine());
                                Console.WriteLine("how many Engin ");
                                noOfEng = int.Parse(Console.ReadLine());
                                theGarage.ParkVehicle(new Car(regno, color, noWheels, noOfEng));
                                break;
                            case "Bus":
                                Console.WriteLine("Enter registration no ");
                                regno = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter color of Bus ");
                                color = Console.ReadLine();
                                Console.WriteLine("how many wheels ");
                                noWheels = int.Parse(Console.ReadLine());
                                Console.WriteLine("Which fuel Type ");
                                fuelType = Console.ReadLine();
                                theGarage.ParkVehicle(new Bus(regno, color, noWheels, fuelType));
                                break;
                            case "Motorcycle":
                                Console.WriteLine("Enter registration no ");
                                regno = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter color of Motorcycle ");
                                color = Console.ReadLine();
                                Console.WriteLine("how many wheels ");
                                noWheels = int.Parse(Console.ReadLine());
                                Console.WriteLine("Which Cylider Value  ");
                                cylinderV = int.Parse(Console.ReadLine());
                                theGarage.ParkVehicle(new Motorcycle(regno, color, noWheels, cylinderV));
                                break;
                        }

                    }

                    foreach (Vehicle a in theGarage)
                    {
                        Console.WriteLine(a.RegNo + " is " +
                            a.RegNo + "Color " + a.Color + " No of Wheels " +
                            a.NoOfWheels);
                    }

                }

                void UnParkVehicle()
                {
                    Console.WriteLine("If You want to unpark vehicle,");
                    Console.WriteLine("Please, Enter Registartion no of Vehicle");
                    string inputNoasstring = Console.ReadLine();
                    int inputNo;
                    int.TryParse(inputNoasstring, out inputNo);


                    theGarage.UnParkVehicle(inputNo);

                    var filterdGarage = theGarage.
                       Where(x => x.NoOfWheels > 2).
                       OrderBy(x => x.RegNo);


                    foreach (Vehicle a in theGarage)
                    {
                        if (a != null)
                            Console.WriteLine(a.RegNo + " is " +
                                a.RegNo + "Color " + a.Color + " No of Wheels " +
                                a.NoOfWheels);

                    }

                }

                    void SearchByColor()
                    {
                        Console.WriteLine("Please, Enter Color  of Vehicle that you want search on it");
                        string inputColor = Console.ReadLine();


                        theGarage.SearchByColor(inputColor);

                        foreach (Vehicle a in theGarage)
                        {
                            if (a != null && a.Color == inputColor)

                                Console.WriteLine(a.RegNo + " is " +
                                    a.RegNo + "Color " + a.Color + " No of Wheels " +
                                    a.NoOfWheels);

                        }
                    }
                }

                catch (Exception)
                {

                    Console.WriteLine("Invalid Input"); ;
                }
               


            }
        }
    }
        }
   

