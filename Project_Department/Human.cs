using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Project_Department
{
    internal class Human
    {
        protected string name { get; set; }
        protected int age { get; set; }
        protected int id { get; set; }
        protected string email { get; set; }
        protected string phone_number { get; set; }


        public Human() { }
        public Human(string name, int age, int id, string email, string phone_number)
        {
           this.name = name;
           this.age = age;
           this.id = id;
           this.email = email;
           this.phone_number = phone_number;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone_Number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public virtual void show() {
            string message = "Ім'я : " + name + "\n" +
                "Вік : " + age + "\n" +
                "Id : " + id + "\n" +
                "Емейл : " + email + "\n" +
                "Номер телефону : " + phone_number + "\n";

            MessageBox.Show(message , "Інформація про людину : " + name, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
