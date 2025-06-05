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

    }




}

