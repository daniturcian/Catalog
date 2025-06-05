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
using System.Text.RegularExpressions;
using System.Globalization;

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
            SaveMdf.Visible = false;
        }

        private void Afiseaza_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Afiseaza.Visible = true;
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
            Stergere.Visible = true;
            SaveMdf.Visible = false;

            var students = Util.LoadStudentData(@"D:\\UPT\\Semida\\CatalogStudenti\\student.json");
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
            Stergere.Visible = true;
            SaveMdf.Visible = false;

        }

        private void Autentificare_Click(object sender, EventArgs e)
        {
            string userEmail = username.Text.Trim();

            // Validare email
            if (!Util.ValideazaUsername(userEmail))
            {
                MessageBox.Show("Email invalid! Trebuie să fie @gmail.com sau @upt.ro");
                return;
            }
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

            materie.Visible = true;
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
            YearOfStudying.Visible = true;
            Group.Visible = false;
            NumeCurs.Visible = true;
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
            SaveMdf.Visible = false;


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
            SaveBtn.Visible = false;
            DeleteBtn.Visible = false;
            ModifyBtn.Visible = true;
            listBoxCourses.Visible = false;
            Stergere.Visible = true;
            SaveMdf.Visible = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            var students = Util.LoadStudentData(@"D:\\UPT\\Semida\\CatalogStudenti\\student.json");

            var newStudent = new Student
            {
                Name = StudentName.Text.Trim(),
                Birthdate = DateTime.Parse(BirthDate.Text.Trim()),
                YearOfStudying = int.Parse(YearOfStudying.Text.Trim()),
                Group = Group.Text.Trim(),
                Courses = tempCourses.ToList()
            };

            students.Add(newStudent);
            Util.SaveStudents(students, @"D:\\UPT\\Semida\\CatalogStudenti\\student.json");
            MessageBox.Show("Student and courses saved.");
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
                string notaStr = Nota.Text.Trim();
                string crediteStr = NumarCredite.Text.Trim();
                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Numele cursului trebuie completat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(notaStr, out int grade) || grade < 1 || grade > 10)
                {
                    MessageBox.Show("Nota trebuie să fie un număr între 1 și 10.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(crediteStr, out int credits) || credits <= 0)
                {
                    MessageBox.Show("Numărul de credite trebuie să fie un număr întreg pozitiv.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void SearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cautare_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchText.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a student name.");
                return;
            }
            dataGridView1.DataSource = Util.SearchStudent(searchTerm); ;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string name = StudentName.Text.Trim();
            string birthDateStr = BirthDate.Text.Trim();
            string group = Group.Text.Trim();
            string courseName = NumeCurs.Text.Trim();
            int yearOfStudying;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(birthDateStr) ||
                string.IsNullOrWhiteSpace(group) ||
                string.IsNullOrWhiteSpace(courseName) ||
                !int.TryParse(YearOfStudying.Text.Trim(), out yearOfStudying) ||
                !DateTime.TryParse(birthDateStr, out DateTime birthDate))
            {
                MessageBox.Show("Please enter valid student details.");
                return;
            }

            bool deleted = CatalogStudenti.Utilities.Util.DeleteStudent(
                @"D:\\UPT\\Semida\\CatalogStudenti\\student.json",
                name,
                birthDate,
                yearOfStudying,
                group,
                courseName
            );

            if (deleted)
            {
                MessageBox.Show("Student deleted successfully.");
                dataGridView1.DataSource = null; // Clear the grid if needed
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

            StudentName.Clear();
            BirthDate.Clear();
            Group.Clear();
            NumeCurs.Clear();
            YearOfStudying.Clear(); 
        }

        private void SaveMdf_Click(object sender, EventArgs e)
        {
            string name = StudentName.Text.Trim();
            string birthDateStr = BirthDate.Text.Trim();
            string group = Group.Text.Trim();
            string courseName = NumeCurs.Text.Trim();
            string gradeStr = Nota.Text.Trim();
            string creditsStr = NumarCredite.Text.Trim();
            string yearStr = YearOfStudying.Text.Trim();
          

            // Verifică dacă toate câmpurile sunt completate
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(birthDateStr) ||
                string.IsNullOrEmpty(yearStr) || string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Toate câmpurile studentului trebuie completate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validare dată naștere
            if (!DateTime.TryParse(birthDateStr, out DateTime birthDate))
            {
                MessageBox.Show("Data nașterii nu este într-un format valid (ex: 2000-01-01).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validare an studiu
            if (!int.TryParse(yearStr, out int yearOfStudying) || yearOfStudying <= 0)
            {
                MessageBox.Show("Anul de studiu trebuie să fie un număr întreg pozitiv.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs

            //int yearOfStudying;
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(birthDateStr) ||
                string.IsNullOrWhiteSpace(group) ||
                string.IsNullOrWhiteSpace(courseName) ||
                !int.TryParse(YearOfStudying.Text.Trim(), out yearOfStudying) ||
                !int.TryParse(gradeStr, out int grade) ||
                !int.TryParse(creditsStr, out int credits))
            {
                MessageBox.Show("Please enter valid data in all fields.");
                return;
            }

            bool modified = CatalogStudenti.Utilities.Util.ModifyStudent(
               @"D:\\UPT\\Semida\\CatalogStudenti\\student.json",
                name,
                birthDate,
                yearOfStudying,
                group,
                courseName,
                grade,
                credits
            );

            if (modified)
            {
                MessageBox.Show("Student information updated successfully.");
                dataGridView1.DataSource = null; // optionally refresh the grid
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            string input = StudentName.Text.Trim();

            // Regex: First letter uppercase, rest lowercase letters (can be adjusted for more complex names)
            bool isValid = Regex.IsMatch(input, @"^[A-Z][a-zA-Z]*$");

            if (!isValid)
            {
                StudentName.BackColor = Color.LightCoral;
                MessageBox.Show("Nume Invalid.");
                //StudentName.Clear(); // Clear the input if invalid
            }
            else
            {
                StudentName.BackColor = Color.White; // Reset background when valid
            }
        }

        private void BirthDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BirthDate_Leave(object sender, EventArgs e)
        {
            string input = BirthDate.Text.Trim();
            string pattern = @"^(19|20)\d{2}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$";

            bool isFormatValid = Regex.IsMatch(input, pattern);
            bool isDateValid = DateTime.TryParseExact(input, "yyyy-MM-dd",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None, out _);

            if (!isFormatValid || !isDateValid)
            {
                BirthDate.BackColor = Color.LightCoral;
                MessageBox.Show("Data nasterii este invalida.");
            }
            else
            {
                BirthDate.BackColor = Color.White;
            }
        }
    }
}
