using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherService teacherService = new TeacherService();
            TeacherModel[] teachers = teacherService.Create(5);
            teacherService.Show(teachers);
            TeacherModel teacher = teacherService.GetTeacher(teachers[1]._id, teachers);
            teacherService.Show(teacher);
            TeacherModel newTeacher = new TeacherModel("Ani", 27, "Math");
            newTeacher._id = teacher._id;
            teacherService.Edit(teachers, newTeacher);
            teacherService.Show(newTeacher);
            StudentService studentService = new StudentService();
            StudentModel[] students = studentService.Create(5);
            studentService.Swap(students, teachers);
            studentService.Show(students);
            StudentModel student = studentService.GetStudent(students[0]._id, students);
            studentService.Show(student);
            StudentModel newStudent = new StudentModel("Levon", 22);
            newStudent._id = student._id;
            studentService.Edit(students, newStudent);
            studentService.Show(students);
            
            
        }
    }
}
