using System;
using System.Collections.Generic;
using System.Text;

namespace UpcstingDowncasting
{
     public abstract class School
    {
        public string SchoolName;
        public abstract void Reading();
        public virtual void LastLesson()
        {
            Console.WriteLine("");
        }
    }
}
