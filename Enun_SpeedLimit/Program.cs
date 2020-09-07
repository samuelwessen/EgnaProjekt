using System;

namespace Enun_SpeedLimit
{
    class Program
    {
        public enum SpeedLimits
        {
            Slow,
            Normal,
            Fast,
            Illegal,
        }        


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current speed");
            var speedlimit = Convert.ToInt32(Console.ReadLine());
            var _speedlimit = SpeedLimits.Illegal;

            switch (speedlimit)
            {
                case int s when s <= 50:
                    _speedlimit = SpeedLimits.Slow;
                    break;

                case int s when s > 50 && s <= 90:
                    _speedlimit = SpeedLimits.Normal;
                    break;

                case int s when s > 90 && s <= 120:
                    _speedlimit = SpeedLimits.Fast;
                    break;

                case int s when s > 120:
                    _speedlimit = SpeedLimits.Illegal;
                    break;
            }

            switch (_speedlimit)
            {
                case SpeedLimits.Slow:
                    Console.WriteLine("Your speed is below 50km/h you are driving to slow");
                    break;

                case SpeedLimits.Normal:
                    Console.WriteLine("Your speed is between 50km-90/h you are driving as you should");
                    break;

                case SpeedLimits.Fast:
                    Console.WriteLine("Your are driving to fast drop your speed to the speedlevel");
                    break;

                case SpeedLimits.Illegal:
                    Console.WriteLine("Your are driving way to fast you are fucked!");
                    break;

            }







        }
    }
}
