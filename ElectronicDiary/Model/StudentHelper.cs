using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Model
{
    class StudentHelper : Model
    {
        public static Student Student { get; set; }

        public List<TeacherGroup> GetStudentSubjects()
        {
            //context.TeacherGroups.First().
            return context.TeacherGroups.Where(i => i.GroupId == Student.GroupId).ToList();
        }

        public TeacherSubject GetTeacherSubject()
        {
            return context.TeacherSubjects.FirstOrDefault();
        }

        public List<Task> GetStudentTasks(TeacherSubject teacherSubject)
        {
            return context.Tasks.Where(i => i.TeacherGroup.TeacherSubject.TeacherId == teacherSubject.TeacherId).ToList();
        }


    }
}
