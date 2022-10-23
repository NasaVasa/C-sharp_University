using System.Text.Json;

namespace test.Classes;

public class Campus
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Bad name of campus");
            }

            name = value;
        }
    }

    private string address;

    public string Address
    {
        get => address;
        set
        {
            if (value.Length <= 10)
            {
                throw new ArgumentException("Bad address of campus");
            }

            address = value;
        }
    }

    public List<Classroom> Classrooms { get; set; }

    public void AddClassroom(List<Classroom> _classroomList)
    {
        foreach (var _currentClassroom in _classroomList)
        {
            Classrooms.Add(_currentClassroom);
        }
    }

    public void AddClassroom(Classroom _classroom)
    {
        Classrooms.Add(_classroom);
    }

    public Campus(string _name, string _address, List<Classroom> _classrooms)
    {
        Name = _name;
        Address = _address;
        Classrooms = _classrooms;
    }

    public Campus(string _name, string _address)
    {
        Name = _name;
        Address = _address;
        Classrooms = new List<Classroom>();
    }
    
    public Classroom this[int index]
    {
        get =>  Classrooms[index];
        set => Classrooms[index] = value;
    }

    private JsonSerializerOptions options = new JsonSerializerOptions()
    {
        WriteIndented = true
    };

    public override string ToString()
    {
        return JsonSerializer.Serialize(this, options);
    }
    public static bool operator ==(Campus a, Campus b)
    {
        return Equals(a, b);
    }

    public static bool operator !=(Campus a, Campus b)
    {
        return !(a == b);
    }

    public static bool operator true(Campus a)
    {
        return a.Classrooms.Count > 0;
    }

    public static bool operator false(Campus a)
    {
        return !a;
    }

    public static bool operator !(Campus a)
    {
        return a ? false : true;
    }
}