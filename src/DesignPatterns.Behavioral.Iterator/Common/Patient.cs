namespace DesignPatterns.Behavioral.Iterator.Common
{
    public class Patient
    {
        public Patient(string name, ePatientType patientType)
        {
            this.Name = name;
            this.Type = patientType;
        }
        public readonly ePatientType Type;
        public readonly string Name;
    }
};
