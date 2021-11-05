using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class TeacherService
    {
        public TeacherModel[] Create(int count)
        {
            TeacherModel[] teachers = new TeacherModel[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                teachers[i] = new TeacherModel($"name-{i}", (ushort)rnd.Next(24, 80), $"subject-{i}");
            }
            return teachers;
        }
        public void Show(TeacherModel[] teachers)
        {
            Console.WriteLine("-----------------");
            for (int i = 0; i < teachers.Length; i++)
            {
                string teacherDetali = $" id  {teachers[i]._id} \n name  {teachers[i]._name}\n age {teachers[i]._age}\n subject {teachers[i]._subject}";
                Console.WriteLine(teacherDetali);
                Console.WriteLine("-----------------");


            }
        }
        public TeacherModel GetTeacher(Guid id, TeacherModel[] teachers)
        {
            TeacherModel teacher = null;
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._id == id)
                {
                    teacher = teachers[i];
                }

            }
            return teacher;
        }
        public void Show(TeacherModel teacher)
        {
            Console.WriteLine("-----------------");

            string teacherDetali = $" id  {teacher._id} \n name  {teacher._name}\n age {teacher._age}\n subject {teacher._subject}";
            Console.WriteLine(teacherDetali);
            Console.WriteLine("-----------------");
        }
        public TeacherModel[] Edit(TeacherModel[] teachers, TeacherModel teacher)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i]._id == teacher._id)
                {
                    teachers[i] = teacher;
                }

            }
            return teachers;
        }



    }
}
