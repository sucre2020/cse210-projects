using System;

namespace ExerciseTracker
{
    public class StationaryBicycle : Activity
    {
        private double speed;

        public StationaryBicycle(DateTime date, int length, double speed)
            : base(date, length)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return speed * (length / 60.0);
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60.0 / speed;
        }
    }
}