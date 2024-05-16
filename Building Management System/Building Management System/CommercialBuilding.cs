using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class CommercialBuilding : Building, IBuilding
    {
        public void Build()
        {
            Console.WriteLine("Building a commercial building");
        }
        public void BuildingType()
        {
            Console.WriteLine("This is a Commercial type Building");
        }
    }
}
