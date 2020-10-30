using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Model
{
    class TeacherHelper : Model
    {
        public static Teacher Teacher { get; set; } = new Teacher() { IdTeacher = 2 };

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

        public List<TeacherGroup> GetTeacherGroups(TeacherSubject subject)
        {
            return context.TeacherGroups.Where(i => i.TeacherId == Teacher.IdTeacher && i.TeacherSubject.IdTeacherSubject == subject.IdTeacherSubject).ToList();
        }

        public List<Task> GetTasks(TeacherGroup teacherGroup)
        {
            return context.Tasks.Where(i => i.TeacherGroupId == teacherGroup.IdTeacherGroup).ToList();
        }

    }
}
