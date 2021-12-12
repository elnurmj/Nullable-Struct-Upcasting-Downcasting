using System;

namespace GetSetIerarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Chefs chefs = new Chefs();
            chefs.ReceptsProperty = "Restaurant secrets";
            Console.WriteLine(chefs.ReceptsProperty);
            
        }
    }
}
