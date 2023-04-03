using System;

namespace ExerciseTracker
{
    public class Running : Activity
    {
        private double distance;

        public Running(DateTime date, int length, double distance)
            : base(date, length)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / (length / 60.0);
        }

        public override double GetPace()
        {
            if (distance == 0) return 0;
            return (length / distance) / 60.0;
        }
    }
}