using System;
using System.Collections.Generic;
namespace Project_Csharp_Payroll {
    class Program {
        static void Main (string[] args) {

            List<Staff> myStaff;
            FileReader fr = new FileReader();
            int month =3;
            int year = 2015;

            while( year == 0 ){
                Console.WriteLine ("\nPlease enter the year: ");
                var input = Console.ReadLine();
                try{
                    year = Int32.Parse(input);
                }catch(FormatException ex){
                    Console.WriteLine ("The value you entered {0} is not interger value,{1}",input,ex);
                }
            }

            
            while( month == 0 ){
                Console.WriteLine ("\nPlease enter the month: ");
                var input = Console.ReadLine();
                try{
                    month = Int32.Parse(input);
                    if(month < 1 || month > 12){
                        Console.WriteLine("The month {0} is not valid",input);
                        month = 0;
                    }
                }catch(FormatException ex){
                    Console.WriteLine ("The value you entered {0} is not interger value,{1}",input,ex);
                }
            }

            myStaff =  fr.ReadFile();
            for(int i = 0; i< myStaff.Count; i++){
                Console.WriteLine ("Enter hours for {0}", myStaff[i].NameOfStaff);
                var input = Console.ReadLine();
                try{
                    myStaff[i].HoursWorked = Int32.Parse(input);  
                    myStaff[i].CalculatePay();    
                    Console.WriteLine(myStaff[i].ToString());
                }catch(FormatException ex){
                    Console.WriteLine ("The value you entered {0} is not interger value,{1}",input,ex);   
                    i--;
                }
            }

            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);

        }
    }
}