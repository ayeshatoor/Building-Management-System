using System;
using System.Collections.Generic;

namespace Building_Management_System
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                              Building Management System                                                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            System.Threading.Thread.Sleep(1000);

            var buildingManager = BuildingManager.CreateManager();
            var securityService = new SecuritySystem();
            var serviceSystem = new ServiceSystem(securityService);
            var facade = new BuildingFacade();
            IBuilding building = null;

            int userOption;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Maintaining Service Systems by Default");
            System.Threading.Thread.Sleep(1000);
            do
            {
                Console.ResetColor();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Build Commercial Building");
                Console.WriteLine("2. Build Residential Building");
                Console.WriteLine("3. Maintain Existing Building");
                Console.WriteLine("4. Perform Security Checks on Existing Buildings");
                Console.WriteLine("5. Exit");
                userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        building = buildingManager.GetBuilding(BuildingType.Commercial);
                        building.Build();
                        facade.AddBuilding(building);
                        BuildingFunctions(building, 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        serviceSystem.Maintain();
                        break;
                    case 2:
                        building = buildingManager.GetBuilding(BuildingType.Residential);
                        building.Build();
                        facade.AddBuilding(building);
                        BuildingFunctions(building, 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        serviceSystem.Maintain();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter the building you want: ");
                        building = facade.GetBuilding(Console.ReadLine());
                        if (building != null)
                        {
                            Console.WriteLine("Do you want to reset building name? 0 for no / 1 for yes");
                            BuildingFunctions(building, int.Parse(Console.ReadLine()));
                            Console.ForegroundColor = ConsoleColor.Green;
                            serviceSystem.Maintain();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Building was not found!");
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        facade.PerformSecurityChecks();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option");
                        break;
                }
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
            } while (userOption != 5);

            void BuildingFunctions(IBuilding building, int check)
            {
                int BuildingUserOption;

                if (check == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nSet a Building Name.");
                    building.SetBuildingName();
                }

                do
                {
                    Console.ResetColor();
                    Console.WriteLine("Choose an option for building operation:");
                    Console.WriteLine("1. Building Type");
                    Console.WriteLine("2. Open Building");
                    Console.WriteLine("3. Close Building");
                    Console.WriteLine("4. Perform Security Check");
                    Console.WriteLine("5. Pay Utilities");
                    Console.WriteLine("6. Exit");
                    BuildingUserOption = int.Parse(Console.ReadLine());

                    switch (BuildingUserOption)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            building.BuildingType();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            building.OpenBuilding();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            building.CloseBuilding();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            building.PerformSecurityCheck();
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            building.PayUtilities();
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Exiting...");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine();
                } while (BuildingUserOption != 6);
            }
            Console.ReadKey();
        }
    }
}