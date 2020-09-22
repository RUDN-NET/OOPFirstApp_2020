using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace OOPFirstApp.Students
{
    class StudentManager
    {
        //private const string __StudentsDataFile = "Data\\Students.csv";
        private const string __StudentsDataFile = @"Data\Students.csv";
        private const string __GroupsDataFile = @"Data\Groups.csv";

        public static void Process()
        {
            var students_list = GetStudents(__StudentsDataFile);

            Console.WriteLine("Студенты");
            foreach (var student in students_list)
                Console.WriteLine(student);

            Console.WriteLine();

            var groups_list = GetGroups(__GroupsDataFile);

            Console.WriteLine("Группы");
            foreach (var group in groups_list)
                Console.WriteLine(group);

            WriteStudents(students_list, "new_students.csv");

            Console.WriteLine();
        }

        public static void WriteStudents(Student[] stuents, string FileName)
        {
            // Некорректное использование FileStream и StreamWriter
            var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            var writer = new StreamWriter(stream);

            writer.WriteLine("Id;SurName;Name;Patronymic;Birthday;Rating;GroupId");

            foreach (var student in stuents)
            {
                writer.WriteLine("{0};{1};{2};{3};{4:dd.mm.yyyy};{5};{6}",
                    student.Id, 
                    student.Surname, student.Name, student.Patronymic,
                    student.Birthday/*.ToString("dd.mm.yyyy")*/, 
                    student.Rating.ToString(CultureInfo.InvariantCulture), 
                    student.GroupId);
            }

            writer.Flush(); // Сбросить всё содержимое буфера записи в файл перед закрытием

            stream.Close();
        }

        public static Student[] GetStudents(string FileName)
        {
            // Некорректное использование FileStream и StreamReader
            Stream data_stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(data_stream/*, System.Text.Encoding.GetEncoding(866)*/);

            if (!reader.EndOfStream)
                reader.ReadLine();

            var students_list = new List<Student>();

            while (!reader.EndOfStream)
            {
                var str = reader.ReadLine();
                //Console.WriteLine(str);

                const char separator = ';';
                var values = str.Split(separator);

                var student = new Student();
                student.Id = int.Parse(values[0]);
                student.Surname = values[1];
                student.Name = values[2];
                student.Patronymic = values[3];
                student.Birthday = DateTime.Parse(values[4]);
                student.Rating = double.Parse(values[5].Replace(".", ",")); // Заменяем в строке точку на запятую
                student.Rating = double.Parse(values[5], CultureInfo.InvariantCulture);
                student.GroupId = int.Parse(values[6]);

                students_list.Add(student);

            }

            data_stream.Close();

            return students_list.ToArray();
        }

        public static Group[] GetGroups(string FileName)
        {
            // Некорректное использование StreamReader - не хватает конструкции using(...) { ... }
            var reader = new StreamReader(FileName);

            if (!reader.EndOfStream)
                reader.ReadLine();

            var groups = new List<Group>();

            while (!reader.EndOfStream)
            {
                var str = reader.ReadLine();

                var values = str.Split(';');

                var group = new Group();
                group.Id = int.Parse(values[0]);
                group.Name = values[1];
                group.Course = int.Parse(values[2]);
                group.Description = values[3];

                groups.Add(group);
            }

            reader.Close();

            return groups.ToArray();
        }
    }
}
