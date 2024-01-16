using DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts;
using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;

namespace DesingPatterns.Creational.Factory.WithDesignPatter
{
    public class WorkoutFactory
    {
        public IWorkout Create(eMuscularGroup muscularGroup)
        {
            IWorkout workout = null;

            switch (muscularGroup)
            {
                case eMuscularGroup.ARM:
                    workout = new Arms();
                    break;
                case eMuscularGroup.LEG:
                    workout = new Leg();
                    break;
                case eMuscularGroup.BREAST:
                    workout = new BreastPlate();
                    break;
                case eMuscularGroup.BACK:
                    workout = new Back();
                    break;
                case eMuscularGroup.SHOULDER:
                    workout = new Shoulder();
                    break;
            }

            return workout;
        }
    }
}
