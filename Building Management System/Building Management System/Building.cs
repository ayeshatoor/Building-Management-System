using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public abstract class Building : IBuilding
    {
        public string BuildingName { get; set; }

        public void Build() { }

        public void BuildingType() { }

        public void OpenBuilding()
        {
            Console.WriteLine($"{BuildingName} is now open for public access.");
        }

        public void CloseBuilding()
        {
            Console.WriteLine($"{BuildingName} is now closed.");
        }

        public void PerformSecurityCheck()
        {
            Console.WriteLine($"Security check performed at {BuildingName}.");
        }

        public void PayUtilities()
        {
            Console.WriteLine($"Utilities paid for {BuildingName}.");
        }

        public void SetBuildingName()
        {
            Console.Write("Enter building name: ");
            BuildingName = Console.ReadLine();
        }
    }
}
