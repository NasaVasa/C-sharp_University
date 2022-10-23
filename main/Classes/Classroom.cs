using System.Text.Json;
using test.Enums;

namespace test.Classes;

public abstract class Classroom
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("Bad name of classroom");
            }

            name = value;
        }
    }

    private int seats;

    public int Seats
    {
        get => seats;
        set
        {
            if (value <= 5)
            {
                throw new ArgumentException("Bad number of seats!");
            }

            seats = value;
        }
    }
    public bool IsMicro { get; set; }

    private ClassroomTypes type;
    public ClassroomTypes Type { get; set; }

    public Classroom( string _name, int _seats, bool _isMicro, ClassroomTypes _type)
    {
        Name = _name;
        Seats = _seats;
        IsMicro = _isMicro;
        Type = _type;
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