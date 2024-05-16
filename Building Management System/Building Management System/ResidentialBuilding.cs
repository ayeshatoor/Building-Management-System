using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class ResidentialBuilding : Building, IBuilding
    {
        public void Build()
        {
            Console.WriteLine("Building a residential building");
        }
        public void BuildingType()
        {
            Console.WriteLine("This is a Residential type Building");
        }
    }
}
