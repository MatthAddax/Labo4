using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.Model
{
    public class AllStudents
    {
        public static IEnumerable<Student> Students { get; set; }

        public static IEnumerable<Student> GetAllStudents()
        {
            return Students = new List<Student>
            {
                new Student("Matthieu Meunier", 23),
                new Student("Vassili Ilouridzé", 21),
                new Student("Justin Picquard", 21)
            };
        }
    }
}
