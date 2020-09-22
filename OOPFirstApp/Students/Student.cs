using System;

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

        public override string ToString()
        {
            // Конкатинация строк - очень медленная
            //return "[Id:" + Id + "] " + Surname + " " + Name + " " + Patronymic + " (" + Birthday + ")" + "[GroupId:" + GroupId + "] - " + Rating;
            //return string.Format( // Форматирование строк
            //    "[Id:{0}] {1} {2} {3} ({4})[GroupId:{5}] - {6}",
            //    Id, Surname, Name, Patronymic, Birthday, GroupId, Rating);
            //return $"[Id:{Id}] {Surname} {Name} {Patronymic} ({Birthday})[GroupId:{GroupId}] - {Rating}";
            //return $"[Id:{Id}] {Surname} {Name} {Patronymic} ({Birthday.ToShortDateString()})[GroupId:{GroupId}] - {Rating}";
            //return $"[Id:{Id}] {Surname} {Name} {Patronymic} ({Birthday:dd.MM.yy})[GroupId:{GroupId}] - {Rating}";
            return $"[Id:{Id}] {Surname} {Name} {Patronymic} ({Birthday:dd.MMMM.yy})[GroupId:{GroupId}] - {Rating}";
        }
    }
}
