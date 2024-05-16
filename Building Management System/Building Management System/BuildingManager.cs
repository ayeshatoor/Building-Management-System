using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    sealed class BuildingManager
    {
        public static BuildingManager Instance;
        private static readonly object _lock = new object();
        private BuildingManager() { }

        public static BuildingManager CreateManager()
        {
            if(Instance == null)
            {
                lock (_lock)
                {
                    if(Instance == null)
                    {
                        Instance = new BuildingManager();
                    }
                }
            }
            return Instance;
        }


        public IBuilding GetBuilding(BuildingType type)
        {
            return BuildingFactory.GetBuilding(type);
        }
    }
}
