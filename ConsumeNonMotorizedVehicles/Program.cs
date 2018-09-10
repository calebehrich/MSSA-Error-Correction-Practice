using Enumerations;
using Structures;
using System;


namespace ConsumeNonMotorizedVehicles
{
    class Program
    {
       

        static void Main(string[] args)
        {
            try
            {
                    Bicycle bike = new Bicycle()
                    {
                        TerrainType = TerrainType.Beach,
                        NoOfTires = 2
                    };

                Tricycle trike = new Tricycle()
                {
                    TerrainType = TerrainType.City,
                    NoOfTires = 3
                };

                    Bicycle bikeTwin = bike;
                    bikeTwin.TerrainType = TerrainType.AllTerrain;
                    Console.WriteLine($"bike has terrain type {bikeTwin.TerrainType}");

                    Tricycle trikeTwin = trike;
                    trikeTwin.TerrainType = TerrainType.Mountain;
                    Console.WriteLine($"trike has terrain type {trikeTwin.TerrainType}");
            }
            catch (Exception e )
            { throw e; }

            
        }

      
    }
}
