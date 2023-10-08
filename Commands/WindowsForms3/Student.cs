using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Student()
        {
            this.Id = 0;
            this.Name = "--";
            this.Surname = "--";
            this.Gender = "--";
            this.Age = 0;
        }

        public string PrintStudent(Student student)
        {
            if (student == null)
                return "None";

            return $"Name: {student.Name}\nSurname: {student.Surname}\nGender: {student.Gender}\nAge: {student.Age.ToString()}";

        }

    }
}
