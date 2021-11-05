using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University
{

    public class StudentService
    {
        public StudentModel[] Create(int count)
        {
            StudentModel[] students = new StudentModel[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new StudentModel($"name-{i}", (ushort)rnd.Next(18, 25));
            }
            return students;
        }
        public void Show(StudentModel[] students)
        {
            Console.WriteLine("-----------------");
            for (int i = 0; i < students.Length; i++)
            {
                string teacherDetalis = $" age  {students[i]._teacher._age} \n id  {students[i]._teacher._id}\n name {students[i]._teacher._name}\n subject {students[i]._teacher._subject}";
                string studentDetali = $" id  {students[i]._id} \n name  {students[i]._name}\n age {students[i]._age}\n teacher \n  {teacherDetalis}";
                Console.WriteLine(studentDetali);
                Console.WriteLine("-----------------");


            }
        }
        public StudentModel GetStudent(Guid id, StudentModel[] students)
        {
            StudentModel student = null;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._id == id)
                {
                    student = students[i];
                }
            }
            return student;
        }
        public void Show(StudentModel student)
        {
            Console.WriteLine("-----------------");
            string teacherDetalis = $" age  {student._teacher._age} \n id  {student._teacher._id}\n name {student._teacher._name}\n subject {student._teacher._subject}";
            string studentDetali = $" id  {student._id} \n name  {student._name}\n age {student._age}\n teacher\n {teacherDetalis}";
            Console.WriteLine(studentDetali);
            Console.WriteLine("-----------------");
        }
        public StudentModel[] Edit(StudentModel[] students, StudentModel student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]._id == student._id)
                {
                    students[i]._name = student._name;
                    students[i]._age = student._age;
                }
            }
            return students;
        }
        public StudentModel[] Swap(StudentModel[] students, TeacherModel[] teachers)
        {
            int k = 0;
            for (int i = 0; i < students.Length; i++)
            {

                students[i]._teacher = teachers[k];
                k++;
                if (k == teachers.Length)
                {
                    k = 0;

                }
            }
            return students;
        }
    }

}
