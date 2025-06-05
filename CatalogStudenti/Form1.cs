using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogStudenti.Utilities;
using System.IO;
using Newtonsoft.Json;

namespace CatalogStudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username.Visible = true;
            password.Visible = true;
            Autentificare.Visible = true;
            Adaugare.Visible = false;
            Stergere.Visible = false;
            Cautare.Visible = false;
            dataGridView1.Visible = false;
            SearchText.Visible = false;
            Afiseaza.Visible = false;
            StudentName.Visible = false;
            BirthDate.Visible = false;
            YearOfStudying.Visible = false;
            Group.Visible = false;
            NumeCurs.Visible = false;
            Nota.Visible = false;
            NumarCredite.Visible = false;
            nume.Visible = false;
            datanasteri.Visible = false;   
            anuldestudiu.Visible = false;
            grupa.Visible = false;
            materie.Visible = false;
            notaluata.Visible = false;
            nrcredite.Visible = false;
            SaveBtn.Visible = false;
            DeleteBtn.Visible = false;
            ModifyBtn.Visible = false;
            btnAddCourse.Visible = false;
            listBoxCourses.Visible = false;
            Converter.ConvertTxtToJson("student.txt", "student.json");

        }

        private void Afiseaza_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Afiseaza.Visible = false;
            StudentName.Visible = false;
            BirthDate.Visible = false;
            YearOfStudying.Visible = false;
            Group.Visible = false;
            NumeCurs.Visible = false;
            Nota.Visible = false;
            NumarCredite.Visible = false;
            nume.Visible = false;
            datanasteri.Visible = false;
            anuldestudiu.Visible = false;
            grupa.Visible = false;
            materie.Visible = false;
            notaluata.Visible = false;
            nrcredite.Visible = false;
            SaveBtn.Visible = false;
            DeleteBtn.Visible = false;
            ModifyBtn.Visible = true;
            btnAddCourse.Visible = false;
            listBoxCourses.Visible = false;

            var students = Util.LoadStudentData("student.json");
                DisplayInGrid(students);
            

        }
        private List<Course> tempCourses = new List<Course>();

        private void Adaugare_Click(object sender, EventArgs e)
        {
            StudentName.Visible = true;
            BirthDate.Visible = true;
            YearOfStudying.Visible = true;
            Group.Visible = true;
            NumeCurs.Visible = true;
            Nota.Visible = true;
            NumarCredite.Visible = true;
            dataGridView1.Visible = false;
            Afiseaza.Visible = true;
            nume.Visible = true;
            datanasteri.Visible = true;
            anuldestudiu.Visible = true;
            grupa.Visible = true;
            materie.Visible = true;
            notaluata.Visible = true;
            nrcredite.Visible = true;
            SaveBtn.Visible = true;
            DeleteBtn.Visible = false;
            ModifyBtn.Visible = true;
            btnAddCourse.Visible = true;

        }

        private void Autentificare_Click(object sender, EventArgs e)
        {
            if (Util.Authenticate(username.Text, password.Text))
            {
                username.Visible = false;
                password.Visible = false;
                username_label.Visible = false;
                password_label.Visible = false;
                Autentificare.Visible = false;
                Adaugare.Visible = true;
                Stergere.Visible = true;
                Cautare.Visible = true;
                SearchText.Visible = true;
                Afiseaza.Visible = true;
                nume.Visible = false;
                datanasteri.Visible = false;
                anuldestudiu.Visible = false;
                grupa.Visible = false;
                materie.Visible = false;
                notaluata.Visible = false;
                nrcredite.Visible = false;
                SaveBtn.Visible = false;
                DeleteBtn.Visible = false;
                ModifyBtn.Visible = true;
                panelUnderline.Visible = false;
                AutontificationFailed.Visible = false;
            }
            else
            {
                AutontificationFailed.Text = "User sau parola gresita";
                AutontificationFailed.Visible = true;
                
            }

        }

        private void Stergere_Click(object sender, EventArgs e)
        {

            materie.Visible = false;
            notaluata.Visible = false;
            nrcredite.Visible = false;
            SaveBtn.Visible = false;
            username.Visible = false;
            password.Visible = false;
            Autentificare.Visible = false;
            Adaugare.Visible = true;
            Stergere.Visible = false;
            Cautare.Visible = true;
            dataGridView1.Visible = false;
            SearchText.Visible = true;
            Afiseaza.Visible = true;
            StudentName.Visible = false;
            BirthDate.Visible = false;
            YearOfStudying.Visible = false;
            Group.Visible = false;
            NumeCurs.Visible = false;
            Nota.Visible = false;
            NumarCredite.Visible = false;
            DeleteBtn.Visible = true;
            ModifyBtn.Visible = true;
            StudentName.Visible = true;
            BirthDate.Visible = true;
            YearOfStudying.Visible = true;
            Group.Visible = true;
            nume.Visible = true;
            datanasteri.Visible = true;
            anuldestudiu.Visible = true;
            grupa.Visible = true;
            listBoxCourses.Visible = false;
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            StudentName.Visible = true;
            BirthDate.Visible = true;
            YearOfStudying.Visible = true;
            Group.Visible = true;
            NumeCurs.Visible = true;
            Nota.Visible = true;
            NumarCredite.Visible = true;
            dataGridView1.Visible = false;
            Afiseaza.Visible = true;
            nume.Visible = true;
            datanasteri.Visible = true;
            anuldestudiu.Visible = true;
            grupa.Visible = true;
            materie.Visible = true;
            notaluata.Visible = true;
            nrcredite.Visible = true;
            SaveBtn.Visible = true;
            DeleteBtn.Visible = false;
            ModifyBtn.Visible = true;
            listBoxCourses.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //        string name = StudentName.Text.Trim();
            //        string birthDateStr = BirthDate.Text.Trim();
            //        string group = Group.Text.Trim();

            //        if (!DateTime.TryParse(birthDateStr, out DateTime birthDate) ||
            //            !int.TryParse(YearOfStudying.Text.Trim(), out int yearOfStudying))
            //        {
            //            MessageBox.Show("Check student info format.");
            //            return;
            //        }

            //        if (tempCourses.Count == 0)
            //        {
            //            MessageBox.Show("Add at least one course.");
            //            return;
            //        }

            //        List<string> linesToAppend = new List<string>

            //{
            //    $"{name},{birthDate:yyyy-MM-dd},{yearOfStudying},{group}"
            //};

            //        foreach (var course in tempCourses)
            //        {
            //            linesToAppend.Add($"{course.CourseName},{course.Grade},{course.CreditNumber}");
            //        }

            //        linesToAppend.Add(""); // Empty line to separate students

            //        File.AppendAllLines(@"D:\UPT\Semida\CatalogStudenti\student.txt", linesToAppend);

            //        MessageBox.Show("Student and courses saved.");
            var students = Util.LoadStudentData("students.json");

            var newStudent = new Student
            {
                Name = StudentName.Text.Trim(),
                Birthdate = DateTime.Parse(BirthDate.Text.Trim()),
                YearOfStudying = int.Parse(YearOfStudying.Text.Trim()),
                Group = Group.Text.Trim(),
                Courses = tempCourses.ToList()
            };

            students.Add(newStudent);
            Util.SaveStudents(students, "students.json");
            // Clear form and temporary list
            StudentName.Clear();
            BirthDate.Clear();
            YearOfStudying.Clear();
            Group.Clear();
            tempCourses.Clear();
            listBoxCourses.Items.Clear();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (AutontificationFailed.Visible == true)
            {
                AutontificationFailed.Visible = false;
            }
            string userEmail = username.Text.Trim();
            if(Util.ValideazaUsername(userEmail))
            {
                panelUnderline.BackColor = Color.Green;
            }
            else
            {
                panelUnderline.BackColor = Color.Red;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayInGrid(List<Student> students)
        {
            var flatList = students.SelectMany(s => s.Courses.Select(c => new StudentCourseView
            {
                Name = s.Name,
                Birthdate = s.Birthdate,
                YearOfStudying = s.YearOfStudying,
                Group = s.Group,
                CourseName = c.CourseName,
                Grade = c.Grade,
                CreditNumber = c.CreditNumber
            })).ToList();

            dataGridView1.DataSource = flatList;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            listBoxCourses.Visible = true;
            {
                string courseName = NumeCurs.Text.Trim();
                if (!int.TryParse(Nota.Text.Trim(), out int grade) ||
                    !int.TryParse(NumarCredite.Text.Trim(), out int credits))
                {
                    MessageBox.Show("Grade and credits must be numbers.");
                    return;
                }

                tempCourses.Add(new Course
                {
                    CourseName = courseName,
                    Grade = grade,
                    CreditNumber = credits
                });

                // Optional: update a small DataGridView or ListBox
                listBoxCourses.Items.Add($"{courseName} - Grade: {grade}, Credits: {credits}");

                // Clear inputs
                NumeCurs.Clear();
                Nota.Clear();
                NumarCredite.Clear();
            }
        }
    }
}
