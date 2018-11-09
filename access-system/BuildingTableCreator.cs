using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system
{
    public class BuildingTableCreator
    {
        public int[,] buildingMatrix;

        public BuildingTableCreator(int n, int m)
        {
            buildingMatrix = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    buildingMatrix[i, j] = (i + 1) * 100 + j; 
                }
            }
        }
    }
}
