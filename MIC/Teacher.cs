namespace MIC
{
    class Teacher : People
    {
        int experience;

        string specialization;

        public Teacher(string name, string surname, int age, string specialization, int experience)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.experience = experience;
            this.specialization = specialization;
        }
    }
}