using System;
using System.Globalization;
using System.IO;

namespace OOPFirstApp.Students
{
    class StudentManager
    {
        //private const string __StudentsDataFile = "Data\\Students.csv";
        private const string __StudentsDataFile = @"Data\Students.csv";
        private const string __GroupsDataFile = @"Data\Students.csv";

        public static void Process()
        {
            Stream data_stream = new FileStream(__StudentsDataFile, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(data_stream/*, System.Text.Encoding.GetEncoding(866)*/);

            if (!reader.EndOfStream)
                reader.ReadLine();

            var max_student_count = 100;
            var students = new Student[max_student_count];
            var students_count = 0;

            while (!reader.EndOfStream)
            {
                var str = reader.ReadLine();
                Console.WriteLine(str);

                const char separator = ';';
                var values = str.Split(separator);

                //var culture_ru = CultureInfo.GetCultureInfo("ru");
                //var culture_ru_RU = CultureInfo.GetCultureInfo("ru-RU");

                //var culture_en = CultureInfo.GetCultureInfo("en");
                //var culture_en_US = CultureInfo.GetCultureInfo("en-US");

                var student = new Student();
                student.Id = int.Parse(values[0]);
                student.Surname = values[1];
                student.Name = values[2];
                student.Patronymic = values[3];
                student.Birthday = DateTime.Parse(values[4]);
                //student.Rating = double.Parse(values[5]); // Выдаёт ошибку формата в случае если в качестве разделителя целой и дробной части числа используется точка, а не запятая для рускоязычной культур системы
                student.Rating = double.Parse(values[5].Replace(".", ",")); // Заменяем в строке точку на запятую
                student.Rating = double.Parse(values[5], CultureInfo.InvariantCulture);
                //student.Rating = double.Parse(values[5], CultureInfo.GetCultureInfo("en"));
                student.GroupId = int.Parse(values[6]);

                //students[students_count++] = student;
                students[students_count] = student;
                students_count++;

                if (students_count == max_student_count)
                {
                    max_student_count *= 2;
                    Array.Resize(ref students, max_student_count);
                }
            }

            data_stream.Close();
        }
    }
}
