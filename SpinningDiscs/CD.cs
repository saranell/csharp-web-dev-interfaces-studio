using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public CD (string name, int maxCapacity, string diskType, int someUsedCapacity) : base (name, maxCapacity, diskType, someUsedCapacity)
        {
        }
        public void ReadData()
        {
            Console.WriteLine("Wanna play a game?");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at the rate of 200 - 500 rpm.");
        }
    }
}
