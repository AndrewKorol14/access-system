using access_system.Entities;
using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IBuildingRepositore
    {
        BuildingEntity GetBuilding(string wayToFile);

        void SetBuilding(string directoryForSave, BuildingEntity buildingToWriteToFile);
    }
}
