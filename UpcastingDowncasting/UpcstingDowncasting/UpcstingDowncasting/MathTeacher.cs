using System;
using System.Collections.Generic;
using System.Text;
using UpcstingDowncasting;

namespace UpcastingDowncasting
{
    public class MathTeacher : Teacher
    {
        public override void Reading()
        {
            Console.WriteLine("Math teacher is reading students quiz results");
        }
        public override void LastLesson()
        {
            Console.WriteLine(3);
        }

    }
}
