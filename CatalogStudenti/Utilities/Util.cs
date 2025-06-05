using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using CatalogStudenti;
using Newtonsoft.Json;

namespace CatalogStudenti.Utilities
{
    public static class Util
    {
        public static bool Authenticate(string username, string password)
        {
            string[] lines = File.ReadAllLines("auth.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Console.WriteLine(parts);

                if (parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValideazaUsername(string email)
        {
            return email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) ||
          email.EndsWith("@upt.ro", StringComparison.OrdinalIgnoreCase);

        }

        public static List<Student> LoadStudentData(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Student>(); // Start fresh
           
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Student>>(json);
        }

        public static void SaveStudents(List<Student> students, string filePath)
        {
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<StudentCourseView> SearchStudent(string searchTerm)
        {
        if (!File.Exists("students.json"))
        {
            MessageBox.Show("Student database not found.");    
        }

        var json = File.ReadAllText(@"D:\\UPT\\Semida\\CatalogStudenti\\student.json");
        var allStudents = JsonConvert.DeserializeObject<List<Student>>(json);

        // Case-insensitive match on name
        var filteredStudents = allStudents
            .Where(s => s.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            // Flatten and bind to grid
            var results = filteredStudents.SelectMany(s => s.Courses.Select(c => new StudentCourseView
        {
            Name = s.Name,
            Birthdate = s.Birthdate,
            YearOfStudying = s.YearOfStudying,
            Group = s.Group,
            CourseName = c.CourseName,
            Grade = c.Grade,
            CreditNumber = c.CreditNumber
        })).ToList();
            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("No student found.");
                results = null;

            }
            // DisplayInGrid.DataSource = results;
            return results;
    }

        public static bool DeleteStudent(
                   string filePath,
                   string name,
                   DateTime birthDate,
                   int yearOfStudying,
                   string group,
                   string courseName)
        {
            if (!File.Exists(filePath))
                return false;

            var json = File.ReadAllText(filePath);
            var students = JsonConvert.DeserializeObject<List<Student>>(json);

            var studentToRemove = students.FirstOrDefault(s =>
                s.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                s.Birthdate == birthDate &&
                s.YearOfStudying == yearOfStudying &&
                s.Group.Equals(group, StringComparison.OrdinalIgnoreCase) &&
                s.Courses.Any(c => c.CourseName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
            );

            if (studentToRemove == null)
                return false;

            students.Remove(studentToRemove);

            File.WriteAllText(filePath, JsonConvert.SerializeObject(students, Formatting.Indented));
            return true;
        }

    public static bool ModifyStudent(
    string filePath,
    string name,
    DateTime newBirthDate,
    int newYear,
    string newGroup,
    string newCourseName,
    int newGrade,
    int newCredits)
        {
            if (!File.Exists(filePath))
                return false;

            var json = File.ReadAllText(filePath);
            var students = JsonConvert.DeserializeObject<List<Student>>(json);

            var student = students.FirstOrDefault(s =>
                s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (student == null)
                return false;

            // Update base info
            student.Birthdate = newBirthDate;
            student.YearOfStudying = newYear;
            student.Group = newGroup;

            // Replace course list with the new course
            student.Courses.Clear();
            student.Courses.Add(new Course
            {
                CourseName = newCourseName,
                Grade = newGrade,
                CreditNumber = newCredits
            });

            // Save updated data
            File.WriteAllText(filePath, JsonConvert.SerializeObject(students, Formatting.Indented));
            return true;
        }


    }
}

