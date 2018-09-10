using Enumerations;
using NonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }

        public bool Moving { get; set; }
    }

    public struct Bicycle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }

        public bool Moving { get; set; }
    }
}
