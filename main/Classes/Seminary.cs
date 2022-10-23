using test.Enums;

namespace test.Classes;

public class Seminary : Classroom
{
    public Seminary(string _name, int _seats, bool _isMicro, ClassroomTypes _type) : base(_name, _seats, _isMicro, _type)
    {
        _type = ClassroomTypes.Seminary;
    }
}