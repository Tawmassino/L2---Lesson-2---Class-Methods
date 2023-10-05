using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class Rectangle
    {//PROPERTIES
        public int Height { get; set; }
        public int Width { get; set; }

        //CONSTRUCTOR
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        // ============ CLASS METHODS ============
        public int Plotas()
        {
            int sum = Height * Width; //imame tiesiai properties, o ne konstruktoriu kad objekte nusistatytume maziau rasto
            return sum;
        }

    }
}
