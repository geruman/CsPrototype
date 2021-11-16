using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPrototype
{
    public class Sheep
    {
        public String Name { get; set; }
        public String Color { get; set; }
        public Sheep(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public Sheep Clone()
        {
            Sheep sheep = new Sheep(Name+" Clone",Color);
            return sheep;
        }
        public override string ToString()
        {
            return "A " + Color + " sheep named " + Name;
        }
    }
}
