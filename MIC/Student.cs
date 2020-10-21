namespace MIC
{
    class Student : People
    {
        int LessonsCount { get; set; }

        int[] mark;

        int course;

        public Student(string name, string surname, int age, int course, int lessonsCount)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.course = course;
            LessonsCount = lessonsCount;
            mark = new int[lessonsCount];
        }
    }
}