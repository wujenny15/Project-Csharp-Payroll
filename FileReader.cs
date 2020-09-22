using System;
using System.Collections.Generic;
using System.IO;
namespace Project_Csharp_Payroll
{
    public class FileReader{

        public List<Staff> ReadFile(){
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = {","};

            if(File.Exists(path)){
                StreamReader reader = new StreamReader(path);
                string line;
                while ((line = reader.ReadLine()) != null){
                    result = line.Split(",");
                    if(result[1].Equals("Manager")){
                        Manager manager =  new Manager(result[0]);
                        myStaff.Add(manager);
                    }else {
                        Admin admin = new Admin(result[0]);
                        myStaff.Add(admin);
                    }
                  
                    return myStaff;

                }
                reader.Close();
                return myStaff;
            }else{
                throw new FileNotFoundException();
            }
        }
    }

}