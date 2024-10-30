namespace ParkingLot
{
    public class Program
    {

        public const string BIG_LOT = "BigLot";
        public const string SMALL_LOT = "SmallLot";

        public static void Main(string[] args)
        {
            Console.WriteLine("Insert the amount of SMALL lots available");
            int nSmallLot = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert the amount of BIG lots available");
            int nBigLot = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert the amount of BUSES to park");
            int nBuses = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert the amount of CARS to park");
            int nCars = int.Parse(Console.ReadLine());

            Dictionary<string, int> result = CalculateMinParkingLots(nSmallLot, nBigLot, nBuses, nCars);
            Console.WriteLine("Small Parking Lots Used: {0}", result[SMALL_LOT]);
            Console.WriteLine("Big Parking Lots Used: {0}", result[BIG_LOT]);

        }

        public static Dictionary<string, int> CalculateMinParkingLots(int nSmallLot, int nBigLot, int nBuses, int nCars)
        {
            Dictionary<string, int> result = [];

            //If the weight of the vehicles is bigger than the weight of the parking lots
            //It means that we can't accomodate all the vehicles in the parking lots
            //We can throw an error if this is not a valid state of the program
            //if (CalculateWeight(nCars, nBuses) > CalculateWeight(nSmallLot, nBigLot))
            //{
            //  throw new Exception();
            //}

            //Since buses can only park in big parking lots we calculate that first
            //We won't track the number of buses left
            //if there are more buses than big lots that means that we use all the big lots (And that there will be buses unparked)
            //if not, then we occupied an amount of lots equal to the number of buses
            int usedBigLots = nBuses > nBigLot ? nBigLot : nBuses;

            //If we still have big lots available
            if (nBigLot > usedBigLots)
            {
                //We group the cars to calculate the amount of big lots that they can occupy
                //Since this is an integer division there would be an ncars % 3 amount of cars left to park
                int groupCarsByThree = nCars / 3;
                int bigLotsAvailable = nBigLot - usedBigLots;

                //If there are more lots than group of cars we park all the groups 
                //Otherwise we calculate the amount of cars left to park
                if (bigLotsAvailable >= groupCarsByThree)
                {
                    usedBigLots += groupCarsByThree;

                    //If we reach this point it means that all the vehicles can be parked in big lots
                    //So we return the solution
                    if (usedBigLots < nBigLot)
                    {
                        result.Add(SMALL_LOT, 0);
                        result.Add(BIG_LOT, usedBigLots + 1);
                        return result;
                    }

                    //The number of cars left to park are the ones that where not part of a group
                    nCars %= 3;
                }
                else
                {
                    //Substract the amount of groups of cars parked
                    groupCarsByThree -= bigLotsAvailable;
                    int ungroupedCars = nCars % 3;

                    //The number of cars left to park are all the groups unparked + the cars outside groups 
                    nCars = groupCarsByThree * 3 + ungroupedCars;

                    //All the big lots are used
                    usedBigLots = nBigLot;
                }

            }

            //We use the small lots to fit the remaining cars
            int smallLotsLeft = nSmallLot - nCars;

            //We calculate the amount of small lots used by substracting the total to the ones left
            int usedSmallLots = smallLotsLeft < 0 ? nSmallLot : nSmallLot - smallLotsLeft;

            result.Add(SMALL_LOT, usedSmallLots);
            result.Add(BIG_LOT, usedBigLots);
            return result;
        }
    }
}