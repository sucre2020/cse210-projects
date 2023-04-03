using System;

namespace ExerciseTracker
{
    public class LapSwimming : Activity
    {
        private int laps;

        public LapSwimming(DateTime date, int length, int laps)
            : base(date, length)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            double distance = laps * 50.0 / 1000.0 * 0.62;
            return distance;
        }

        public override double GetSpeed()
        {
            return GetDistance() / (length / 60.0);
        }

        public override double GetPace()
        {
            if (GetDistance() == 0) return 0;
            return (length / GetDistance()) / 60.0;
        }
    }
}
