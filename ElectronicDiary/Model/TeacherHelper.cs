using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Model
{
    class TeacherHelper : Model
    {
        public static Teacher Teacher { get; set; }

        public List<Teacher> GetTeachers()
        {
            return context.Teachers.ToList();
        }

        public List<TeacherSubject> GetTeacherSubjects()
        {
            return context.TeacherSubjects.Where(i => i.TeacherId == Teacher.IdTeacher).ToList();
        }

        public List<TeacherGroup> GetTeacherGroups()
        {
            return context.TeacherGroups.Where(i => i.TeacherId == Teacher.IdTeacher).ToList();
        }

    }
}
