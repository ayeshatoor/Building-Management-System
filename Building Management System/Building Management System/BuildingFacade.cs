using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public class BuildingFacade
    {
        private List<IBuilding> buildings;

        public BuildingFacade()
        {
            buildings = new List<IBuilding>();
        }

        public void AddBuilding(IBuilding building)
        {
            buildings.Add(building);
        }

        public IBuilding GetBuilding(String buildingName)
        {
            foreach (var building in buildings)
            {
                if (building.BuildingName == buildingName)
                {
                    return building;
                }
            }
            return null;
        }

        public void PerformSecurityChecks()
        {
            foreach (var building in buildings)
            {
                building.PerformSecurityCheck();
            }
        }
    }
}
