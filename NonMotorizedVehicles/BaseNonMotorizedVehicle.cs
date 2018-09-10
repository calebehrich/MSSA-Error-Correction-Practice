using Enumerations;

namespace NonMotorizedVehicles
{
    public class BaseNonMotorizedVehicle
    {
        public bool isMoving;
        public BaseNonMotorizedVehicle()
        {
            isMoving = false;
        }
        public bool HasPedals { get;set;}
        public int NoOfWheels { get; set; }
        TerrainType TerrainType { get; set; }

        public bool Moving(bool isMoving)
        {
            return Moving(this.isMoving);
        }
        public bool Driving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }

       
    }
}
