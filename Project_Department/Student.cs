using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Project_Department
{
    public struct grade
    {
        public string subject;
        public int mark;
    }


    internal class Student : Human
    {

        private int rating;
        public List<grade> grade_stud = new List<grade>();


        public Student() { }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        Student(string name, int age, int id, string email, string phone_number) { 
            this.name = name;
            this.age = age;
            this.id = id;
            this.email = email;
            this.phone_number = phone_number;
        }

        //public void subscription_on_course(Course* courseName) { }                                  //Метод підписки на курс
        //public void unbscription_on_course(Course* courseName) { }
        public void add_info(int id, string email, string phone_number) { 
            this.id = id;
            this.email = email;
            this.phone_number = phone_number;
        }                           //Додовання додатковї інформації

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public override void show()
        {
            base.show();
            MessageBox.Show(this.rating.ToString(), "Рейтинг",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  Student& operator ++()
        //  {                                   // Перевантаження префіксного оператора "++"
        //      rating++;
        //      return *this;
        //  }

        //  Student& operator --()
        //  {                                   // Перевантаження префіксного оператора "--"
        //      rating--;
        //      return *this;
        //  }

        //  Student& operator+=(int num) {

        //      rating += num;
        //return * this;
        //  }
        //  Student& operator-=(int num) {

        //      rating -= num;
        //return * this;
        //  }

        //Показати інформацію про студента
        //void show_grades();

        //   multimap<string, int> grade_stud;


        //   ~Student() override; 
      
}
}
