using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class NumberContainer
    {        //property
        public List<int> Numbers { get; set; } = new List<int>();//cia inicijuojam nauja lista kad nebutu null

        public void AddNumber(int number)
        {
            Numbers.Add(number);
        }

        public void PrintAllNumbers()
        {
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
