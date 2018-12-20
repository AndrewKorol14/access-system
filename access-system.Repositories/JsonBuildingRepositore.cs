using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;
using Newtonsoft.Json;
using System.IO;

namespace Repositories
{
    class JsonBuildingRepositore : IBuildingRepositore
    {
        private static object lockObject = new object();

        /// <summary>
        /// Reads information from the specified file, converting it to the building entity
        /// </summary>
        /// <param name="wayToFile">path to file with information</param>
        public BuildingEntity GetBuilding(string wayToFile)
        {
            lock (lockObject)
            {
                return JsonConvert.DeserializeObject<BuildingEntity>(File.ReadAllText(wayToFile));
            }
        }

        public void SetBuilding(string directoryForSave, BuildingEntity buildingToWriteToFile)
        {
            lock (lockObject)
            {
                using (StreamWriter file = File.CreateText(directoryForSave))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, buildingToWriteToFile);
                }
            }
        }
    }
}
