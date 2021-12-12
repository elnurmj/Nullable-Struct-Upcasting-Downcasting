using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetIerarchy
{
    public class Chefs:Restaurant
    {
        private string Recepts;
        public string ReceptsProperty { get { return Recepts; } set { Recepts = value; } }
    }
}
