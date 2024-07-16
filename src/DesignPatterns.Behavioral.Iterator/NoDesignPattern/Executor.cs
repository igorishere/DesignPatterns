using DesignPatterns.Behavioral.Iterator.Common;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.Iterator.NoDesignPattern
{
    public class Executor : ExecutorNoExample
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

            foreach (var patien in patients.OrderBy(p => p.Type).ToList())
                Console.WriteLine($"Patient {patien.Name}, please move to room 404, Doctor Chucrute will examine you.");
        }

        public override string GetName() => "Iterator";
    }
};
