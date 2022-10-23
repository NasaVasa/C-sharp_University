using test.Enums;

namespace test.Classes;

public class Laboratory : Classroom
{
    public Laboratory(string _name, int _seats, bool _isMicro, ClassroomTypes _type) : base(_name, _seats, _isMicro, _type)
    {
        _type = ClassroomTypes.Laboratory;
    }
}