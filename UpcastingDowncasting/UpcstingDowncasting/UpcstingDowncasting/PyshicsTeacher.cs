using System;
using System.Collections.Generic;
using System.Text;
using UpcstingDowncasting;

namespace UpcastingDowncasting
{
    public class Pyshics_Teacher : Teacher
    {
        public override void Reading()
        {
            Console.WriteLine("Pyshics teacher reading his own book");
        }
        public override void LastLesson()
        {
            Console.WriteLine(8);
        }
    }
}
