using DesignPatterns.Behavioral.Iterator.Common;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Iterator.WithDesignPatter
{
    public class Executor : ExecutorWithExample
    {
        public override void Execute()
        {
             var patients = new List<Patient>()
            {
                new Patient("John Frusciante", ePatientType.ADULT),
                new Patient("Barack Obama", ePatientType.ADULT),
                new Patient("Louisiania", ePatientType.PREGNANT),
                new Patient("Barney", ePatientType.ELDERLY),
                new Patient("Marge Simpson", ePatientType.ADULT),
                new Patient("Taylor", ePatientType.CHILD)
            };

            var iterator = new HealthSystemPriorityIterator(patients);

            StartAttendanceByPriority(iterator);
        }

        private void StartAttendanceByPriority(HealthSystemPriorityIterator iterator)
        {
            while(iterator.MoveNext())
                Console.WriteLine($"Patient {iterator.GetNext().Name}, please move to room 404, Doctor Chucrute will examine you.");
        }

        public override string GetName() => "Iterator";
    }
};
