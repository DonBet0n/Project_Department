using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Department
{
    internal sealed class Course
    {

        private string courseName { get; set; }
        private int maxStudent { get; set; }
        private int studentCount { get; set; }
        private int courseCode { get; set; }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int MaxStudent
        {
            get { return maxStudent; }
            set { maxStudent = value; }
        }
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }
        public int CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public Course(string name, int max, int courseCode)
        {
            this.courseName = name;
            this.maxStudent = max;
            this.courseCode = courseCode;
        }//Створити курс

        void show() {
            MessageBox.Show("Назва курсу: " + courseName + "\n" +
                 "Максимальна кількість студентів: " + maxStudent + "\n" +
                 "Кількість студентів на курсі: " + studentCount + "\n" +
                 "ID курсу: " + courseCode + "\n", "Інформація про курс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }                                                    //Показати інформацію про курс
       //bool add_student(Student* newStudent);								//Додати студентів до курсу

        // List<Student> get_studentMap() { }

        //void save_course_info();                                                //Записати студентів до курсу

        //bool operator +(Student* newStudent)
        //{
        //    if (studentMap.size() >= maxStudent)
        //    {
        //        cout << "Досягнуто максимальну кількість студентів для курсу." << endl;
        //        return false;
        //    }
        //    studentMap[newStudent] = newStudent->get_id();      // Додаємо ім'я та ідентифікатор студента до мапи

        //    ++studentCount;
        //    return true;
        //}

        //bool operator -(Student* newStudent)
        //{
        //    auto it = studentMap.find(newStudent);
        //    if (it != studentMap.end())
        //    {
        //        studentMap.erase(it);

        //        --studentCount;
        //        return true;
        //    }
        //    else
        //    {
        //        cout << "Студент не знайдений на курсі" << endl;
        //        return false;
        //    }
        //}

       
    }
}
