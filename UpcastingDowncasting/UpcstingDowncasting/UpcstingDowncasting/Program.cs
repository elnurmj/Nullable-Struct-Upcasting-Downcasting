using System;
using UpcastingDowncasting;

namespace UpcstingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting
            Teacher teacher = new Teacher();
            Student student = new Student();
            MathTeacher mathTeacher = new MathTeacher();
            Pyshics_Teacher pyshics_Teacher = new Pyshics_Teacher();
            School school = student;
            School school1 = teacher;
            School school2 = pyshics_Teacher;
            School school3 = mathTeacher;



            School[] schools = { school, school1, school2, school3 };

            foreach (var item in schools)
            {
                item.Reading();
            }

            #endregion
            #region Downcasting
            School Yasamal = new Teacher();
            School Nerimanov = new Student();
            Teacher Javid = (Teacher) Yasamal;
            Student Sadiq = (Student) Nerimanov;

            object[] objects = { Nerimanov, Javid, Sadiq };

            foreach (var item in objects)
            {
                if (item is Teacher s)
                {
                    s.Reading();
                }
            }

            #endregion

        }


    }
}
