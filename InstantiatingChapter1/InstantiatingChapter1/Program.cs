using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingChapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course biology = new Course();

            biology.CourseName = "Biology 105";
            biology.InstructorName = "Jane Doe";

            Course algebra = new Course();

            algebra.CourseName = "algebra 314";
            algebra.InstructorName = "John Doe";
            
            Console.WriteLine(algebra.InstructorName);
            
        }
    }
}
