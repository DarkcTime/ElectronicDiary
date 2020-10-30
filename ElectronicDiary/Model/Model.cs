using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Model
{
    class Model
    {
        protected static ks54Entities context = new ks54Entities();

        public static bool isStudent = false;  


        public bool IsAuth(string login, string password)
        {
            var student = context.Students.Where(i => i.Login == login && i.Password == password);

            if (student.Count() > 0)
            {
                isStudent = true;
                StudentHelper.Student = student.FirstOrDefault(); 
                return true;
            }

            var teacher = context.Teachers.Where(i => i.Login == login && i.Password == password);

            if (teacher.Count() > 0)
            {
                TeacherHelper.Teacher = teacher.FirstOrDefault();
                return true;


            }

            return false;
        }


        public bool IsStudent()
        {
            return isStudent; 
        }
    }
}
