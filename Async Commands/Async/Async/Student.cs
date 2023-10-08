using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student()
        {
            this.Id = 0;
            this.Name = "--";
            this.Surname = "--";
            this.Age = 0;
        }

        public string PrintStudent(Student student)
        {
            if (student == null)
                return "None";

            return $"ID: {student.Id}\nName: {student.Name}\nSurname: {student.Surname}\nAge: {student.Age.ToString()}";

        }

    }
}
