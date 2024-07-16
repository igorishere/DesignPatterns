using DesignPatterns.Behavioral.Iterator.Common;

namespace DesignPatterns.Behavioral.Iterator;

public interface Iiterator<T>
{
    public T GetNext();

    public bool MoveNext();
}

public class HealthSystemPriorityIterator : Iiterator<Patient>
{
    private int _index;
    private readonly Patient[] _patients;

    public HealthSystemPriorityIterator(IEnumerable<Patient> patients)
    {
        this._index = -1;
        this._patients = SortPatientsByPriority(patients);
    }

    private Patient[] SortPatientsByPriority(IEnumerable<Patient> patients)
    {
        return patients
        .OrderByDescending(p => p.Type)
        .ToArray();
    }

    public Patient GetNext() => _patients[_index];

    public bool MoveNext()
    {
        bool canMoveNext = false;

        var currentPosition = _index+1;
        if (_patients.Length > currentPosition)
        {
            this._index++;
            canMoveNext = true;
        }

        return canMoveNext;
    }
}