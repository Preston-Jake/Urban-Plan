using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            var PrestonBuilding = new Building("722 Davidson Rd")
            {
                Stories = 10,
                Width = 1500.00,
                Depth = 1500.00,

            };
            PrestonBuilding.SetVolume();
            PrestonBuilding.Construct();
            PrestonBuilding.Purchase("Jake Preston");
            PrestonBuilding.SetDesigner("Bob Ross");

            var nashville = new City()
            {
                Name = "Nashville",
                Mayor = "Jake Preston",
                YearEstablished = 1690
            };

            nashville.AddBuilding(PrestonBuilding);

            foreach (var b in nashville.Buildings)
            {
                Console.WriteLine(nashville.Name);
                b.BuildingInfo();
            }
        }



    }
}
