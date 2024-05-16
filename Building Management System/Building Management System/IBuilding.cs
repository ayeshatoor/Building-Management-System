using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Management_System
{
    public interface IBuilding
    {
        void Build();
        string BuildingName { get; set; }

        void BuildingType();

        void OpenBuilding();
        void CloseBuilding();

        void PerformSecurityCheck();

        void PayUtilities();

        void SetBuildingName();
    }
}
