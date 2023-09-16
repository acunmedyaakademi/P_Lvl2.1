using System;
namespace LinkedList
{
	public class Students_System
	{
        public int SchoolNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string LessonName { get; set; }
        public int Note1 { get; set; }
        public int Note2 { get; set; }
        public int Avrange { get; set; }

        public Students_System(int sNo, string name, string surname, string tName, string tSurname, string lName, int note1, int note2, int avrange)
        {
            SchoolNo = sNo;
            StudentName = name;
            StudentSurname = surname;
            TeacherName = tName;
            TeacherSurname = tSurname;
            LessonName = lName;
            Note1 = note1;
            Note2 = note2;
            Avrange = avrange;
        }
    }
}

