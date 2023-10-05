using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace L2___Lesson_2___Class_Methods
{
    public class Library
    {//PROPERTIES
        public List<string> Books { get; set; } = new List<string>();

        //CONSTRUCTOR


        //METHODS

        public void AddBooks(string whatToAdd)
        {
            Books.Add(whatToAdd);
        }


        public void RemoveBooks(string whatToRemove)
        {
            Books.Remove(whatToRemove);
        }


    }
}
