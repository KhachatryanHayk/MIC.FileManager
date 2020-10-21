using System;

namespace MIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("name1", "surname1", 17, 3, 15);
            Student st2 = new Student("name2", "surname2", 17, 3, 15);
            Student st3 = new Student("name3", "surname3", 17, 3, 15);
            Student st4 = new Student("name4", "surname4", 17, 3, 15);
            Student st5 = new Student("name5", "surname5", 17, 3, 15);
            Student st6 = new Student("name6", "surname6", 17, 3, 15);
            Student st7 = new Student("name7", "surname7", 17, 3, 15);
            Student st8 = new Student("name8", "surname8", 17, 3, 15);

            Teacher tch1 = new Teacher("Hakobyan", "Mariam", 50, "Math", 20);

            Group group812 = new Group { GroupNumber = 812 };

            group812.SetGroupPersonal(tch1, st1, st2, st3, st4, st5, st6, st7);

            FilesManager.CreateGroupFile(group812);

            FilesManager.ReadFileInfo();

            Console.ReadLine();
        }
    }
}
