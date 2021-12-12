using System;
using System.Collections.Generic;
using System.Text;

namespace UpcstingDowncasting
{
     public class Student : School
    {
        public override void Reading()
        {
            Console.WriteLine("Student is reading book");
        }
        
    }
}
