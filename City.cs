using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {

        public string Name { get; set; }
        public string Mayor { get; set; }

        public int YearEstablished { get; set; }

        public List<Building> Buildings { get; set; } = new List<Building>();

        public void AddBuilding(Building name)
        {
            Buildings.Add(name);
        }
        public City()
        {

        }
    }

}