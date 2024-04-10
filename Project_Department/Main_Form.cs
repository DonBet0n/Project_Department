using System.Diagnostics;
using System.Reflection;

namespace Project_Department
{
    public partial class MainForm : Form
    {
        void ReadStudentsFromFile(List<Student> students, string filename)
        {
            try
            {
                using (StreamReader file = new StreamReader(filename))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line == "Студент")
                        {
                            line = file.ReadLine();
                            string name = line.Substring(6);

                            line = file.ReadLine();
                            int age = Convert.ToInt32(line.Substring(5));

                            Student student = new Student(name, age);

                            line = file.ReadLine();
                            int id = Convert.ToInt32(line.Substring(4));

                            line = file.ReadLine();
                            string email = line.Substring(7);

                            line = file.ReadLine();
                            string phoneNumber = line.Substring(16);

                            line = file.ReadLine();
                            string rating = line.Substring(9);

                            student.add_info(id, email, phoneNumber);
                            student.Rating = Convert.ToInt32(rating);

                            line = file.ReadLine();

                            while (true)
                            {
                                line = file.ReadLine();

                                if (string.IsNullOrEmpty(line) || line == "Студент" || file.EndOfStream)
                                {
                                    break;
                                }

                                int pos = line.IndexOf(":");
                                if (pos != -1)
                                {
                                    string subjects = line.Substring(1, pos - 1);
                                    int mark = Convert.ToInt32(line.Substring(pos + 1));

                                    //student.grade_stud.Add(subject, mark);

                                    grade newGrade = new grade { subject = subjects, mark = mark };
                                    student.grade_stud.Add(newGrade);


                                }
                            }

                            students.Add(student);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Помилка: " + e.Message);
            }
        }
        void WriteStudentsToFile(List<Student> students, string filename)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filename,false))
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        file.WriteLine("Студент");
                        file.WriteLine("Iм'я: " + students[i].Name);
                        file.WriteLine("Вік: " + students[i].Age);
                        file.WriteLine("Id: " + students[i].ID);
                        file.WriteLine("Емейл: " + students[i].Email);
                        file.WriteLine("Номер телефону: " + students[i].Phone_Number);
                        file.WriteLine("Рейтинг: " + students[i].Rating);
                        file.WriteLine("Оцінки:");
                        foreach (var grade in students[i].grade_stud)
                        {
                            file.WriteLine(" " + grade.subject + ": " + grade.mark);
                        }
                        file.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Помилка: " + e.Message);
            }
        }


        Student student1 = new Student("Pasa", 25);
        Student student2 = new Student("Jena", 18);
        Student student3 = new Student("Bohgdan", 20);

        static List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Student_Form Stud_Form = new Student_Form();
            Stud_Form.Show();
            this.Hide();

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteStudentsToFile(students, @"students.txt");
            Application.Exit();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Teacher_Form Teach_Form = new Teacher_Form();
            Teach_Form.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            ReadStudentsFromFile(students, "students.txt");
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            String name = textBox3.Text;
            int age = Convert.ToInt32(textBox4.Text);

            students.Add(new Student(name, age));
            MessageBox.Show("Студент успішно записаний");

            WriteStudentsToFile(students, @"students.txt");

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);

            MessageBox.Show(students[id].Name + "\n" + students[id].Age, "Інформація про студента", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteStudentsToFile(students, @"students.txt");

        }
    }

}

