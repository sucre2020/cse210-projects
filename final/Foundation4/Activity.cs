using System;

namespace ExerciseTracker
{
    public abstract class Activity
    {
        protected DateTime date;
        protected int length;

        public Activity(DateTime date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return string.Format("{0} ({1} min) - Distance {2:F1} miles, Speed {3:F1} mph, Pace {4:F1} min per mile",
                                 date.ToString("dd MMM yyyy"), length, GetDistance(), GetSpeed(), GetPace());
        }
    }
}
