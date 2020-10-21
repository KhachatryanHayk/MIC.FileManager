using System;
using System.IO;

namespace MIC
{
    static class FilesManager
    {
        static public void CreateGroupFile(Group group)
        {
            string writePath = @"C:\Users\Hayk Khachatryan\Desktop\hta.txt";
            string text = "";
            text += $"Group Number{group.GroupNumber}\n";
            text += $"Teacher: {group.teacher.name} {group.teacher.surname}\n";

            for (int i = 0; i < group.students.Count; i++)
                text += $"Student No{i + 1}: {group.students[i].name} {group.students[i].surname}\n";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                Console.WriteLine($"File Created in {writePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadFileInfo()
        {
            string path = @"C:\Users\Hayk Khachatryan\Desktop\hta.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
