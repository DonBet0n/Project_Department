using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Department
{
    internal class Teacher : Human
    {
        private Course teacherCourse;
        private string teaching_experience;


        public Teacher(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
        public void create_course(string courseName, int maxStudent, int courseCode) { }         //Створення курсу
        public void assigns_grade(Student new_student) { }                                        //Генерація випадкових оцінок
        public void assigns_grade(Student new_student, int count) { }                                 //Задати оцінки для студента
        public void add_info(string email, string phone_number, string teaching_experience) { }    //Додати більше інформації про вчителя

        public override void show() { }

        //Course get_course() { }                                                            //Отримати обєкт курсу

        //string get_teaching_experience(){ } ;


	
}
}
