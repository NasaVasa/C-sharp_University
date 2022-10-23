using test.Classes;
using test.Enums;

var university1 = new University("HSE", 15343);

var campus1 = new Campus("Pokra", "street Pokrovka, 11");
var campus2 = new Campus("Myasnitskaya", "street Tallinskaya, 34");
var campus3 = new Campus("MIEM", "street Myasnitskaya, 11");
var campus8 = new Campus("MIEM", "street Myasnitskaya, 11");

var lecture1 = new Lecture("R202", 130, true, ClassroomTypes.Lecture);
var seminary1 = new Seminary("S234", 20, false, ClassroomTypes.Seminary);
var seminary2 = new Seminary("S236", 25, true, ClassroomTypes.Seminary);
var seminary3 = new Seminary("N233", 20, false, ClassroomTypes.Seminary);
var laboratory1 = new Laboratory("F312", 40, false, ClassroomTypes.Laboratory);

campus1.AddClassroom(lecture1);
campus2.AddClassroom(new List<Classroom>() { seminary1, seminary2, seminary3 });
university1.AddCampus(campus1);
university1.AddCampus(campus2);
campus2[1] = laboratory1;
Console.WriteLine(university1);
var lecture2 = new Lecture("A231", 500, true, ClassroomTypes.Lecture);
var laboratory2 = new Laboratory("C312", 40, false, ClassroomTypes.Laboratory);

var campus4 = new Campus("Main", "1 Jude Berge", new List<Classroom>() { lecture2, laboratory2 });
var campus5 = new Campus("VMK", "street Pushkina, house Colotushkina");

var university2 = new University("MSU", 11230, new List<Campus>() { campus4, campus5 });
Console.WriteLine(university2);