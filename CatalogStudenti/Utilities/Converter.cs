using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatalogStudenti.Utilities
{
    public static class Converter
    {
        public static void ConvertTxtToJson(string txtPath, string jsonPath)
        {
            var students = new List<Student>();

            if (!File.Exists(txtPath))
            {
                Console.WriteLine("TXT file not found.");
                return;
            }

            var lines = File.ReadAllLines(txtPath);
            Student currentStudent = null;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (currentStudent != null)
                    {
                        students.Add(currentStudent);
                        currentStudent = null;
                    }
                    continue;
                }

                var parts = line.Split(',');

                if (parts.Length == 4 && currentStudent == null)
                {
                    // Start of a new student
                    if (DateTime.TryParse(parts[1], out DateTime birthdate))
                    {
                        currentStudent = new Student
                        {
                            Name = parts[0].Trim(),
                            Birthdate = birthdate,
                            YearOfStudying = int.Parse(parts[2]),
                            Group = parts[3].Trim(),
                            Courses = new List<Course>()
                        };
                    }
                    else
                    {
                        Console.WriteLine($"Invalid date format for student: {line}");
                    }
                }
                else if (parts.Length == 3 && currentStudent != null)
                {
                    currentStudent.Courses.Add(new Course
                    {
                        CourseName = parts[0].Trim(),
                        Grade = int.Parse(parts[1]),
                        CreditNumber = int.Parse(parts[2])
                    });
                }
            }

            if (currentStudent != null)
                students.Add(currentStudent); // Add last student if needed

            // Convert to JSON and save
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonPath, json);

            Console.WriteLine("Conversion complete. File saved to " + jsonPath);
        }
    }
}
