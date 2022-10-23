using System.Text.Json;

namespace test.Classes;

public class University
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Bad name of University");
            }

            name = value;
        }
    }

    private int countOfStudents;

    public int CountOfStudents
    {
        get => countOfStudents;
        set
        {
            if (value <= 300 || value >= 20000)
            {
                throw new ArgumentException("Bad value of students");
            }

            countOfStudents = value;
        }
    }


    public List<Campus> Campuses { get; set; }

    public void AddCampus(List<Campus> _campusList)
    {
        foreach (var _currentCampus in _campusList)
        {
            Campuses.Add(_currentCampus);
        }
    }

    public void AddCampus(Campus _campus)
    {
        Campuses.Add(_campus);
    }

    public University(string _name, int _countOfStudents)
    {
        Name = _name;
        CountOfStudents = _countOfStudents;
        Campuses = new List<Campus>();
    }

    public University(string _name, int _countOfStudents, List<Campus> _campusList)
    {
        Name = _name;
        CountOfStudents = _countOfStudents;
        Campuses = _campusList;
    }
    
    public Campus this[int index]
    {
        get =>  Campuses[index];
        set => Campuses[index] = value;
    }
    
    private JsonSerializerOptions options = new JsonSerializerOptions()
    {
        WriteIndented = true
    };

    public override string ToString()
    {
        return JsonSerializer.Serialize(this, options);
    }
}