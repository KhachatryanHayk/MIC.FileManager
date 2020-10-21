using System.Collections.Generic;
using System.Linq;

namespace MIC
{
    class Group
    {
        public int GroupNumber { get; set; }


        public Teacher teacher;
        public List<Student> students;

        public void SetGroupPersonal(Teacher teacher, params Student[] students)
        {
            this.teacher = teacher;
            this.students = students.ToList();
        }
    }
}