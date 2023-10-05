using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class Circle
    {
        public double Radius { get; set; }

        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //methods
        public double CircleArea()//nepaduodame i metoda nieko jei norime naudoti klases properties
        {
            double sum = Radius * 3.14;
            return sum;
        }
    }
}
