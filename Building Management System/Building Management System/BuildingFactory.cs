using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class BuildingFactory
    {
        public static IBuilding GetBuilding(BuildingType type)
        {
            switch (type)
            {
                case BuildingType.Commercial:
                    return new CommercialBuilding();
                case BuildingType.Residential:
                    return new ResidentialBuilding();
                default:
                    throw new ArgumentException("Invalid building type");
            }
        }
    }
}
