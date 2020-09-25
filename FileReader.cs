using System.Collections.Generic;
using System.IO;

namespace Project_Csharp_Payroll
{
    public class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string[] separator = { "," };

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dirInfo = new DirectoryInfo(currentDirectory);
            string fileName = Path.Combine(dirInfo.FullName, "staff.txt");
            var fileInfo = new FileInfo(fileName);

            if (fileInfo.Exists)
            {
                StreamReader reader = new StreamReader(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result = line.Split(",");
                    if (result[1].Trim().Equals("Manager"))
                    {
                        var manager = new Manager(result[0].Trim());
                        myStaff.Add(manager);
                    }
                    else
                    {
                        Admin admin = new Admin(result[0].Trim());
                        myStaff.Add(admin);
                    }
                }
                reader.Close();
                return myStaff;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}