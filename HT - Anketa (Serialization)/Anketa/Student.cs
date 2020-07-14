using System;

namespace Anketa
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }

        public Student()
        {

        }
    }
}
