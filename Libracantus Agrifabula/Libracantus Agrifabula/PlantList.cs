using System;
using System.Collections.Generic;
using System.Text;

namespace Libracantus_Agrifabula
{
    class PlantList
    {
        private List<Plant> plantDirectory = new List<Plant>();

        public void AddPlant(Plant _plant)
        {
            plantDirectory.Add(_plant);
        }
    }
}
