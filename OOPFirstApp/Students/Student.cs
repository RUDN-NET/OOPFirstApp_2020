using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFirstApp.Students
{
    class Student
    {
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public int GroupId { get; set; }
    }
}
