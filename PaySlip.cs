using System;
using System.Collections.Generic;
using System.IO;

namespace Project_Csharp_Payroll
{
    public class PaySlip{

        private int month;
        private int year;
        
        enum MonthOfYear{
            Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec
        }

        public PaySlip(int payMonth, int payYear){
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff){
            string path;
            foreach(Staff stf in myStaff){
                path = stf.NameOfStaff+ ".txt";
                using(StreamWriter sw = new StreamWriter(path)){
                    sw.WriteLine("PAYSLIP FOR {0} {1}",month,year);
                    sw.WriteLine("=============================");
                    sw.WriteLine("Name of Staff: {0}",stf.NameOfStaff);
                    sw.WriteLine("Hours Worked: {0}",stf.HoursWorked);
                    sw.WriteLine("");
                    sw.WriteLine("Basic Pay: ${0}",stf.BasicPay);
                    //TODO: Cast the Object into dynamic type
                    if(stf is Manager){
                        sw.WriteLine("Allowacne: ${0}",((Manager)stf).Allowance);
                    }

                    if(stf is Admin){
                        sw.WriteLine("Overtime: {0}",((Admin)stf).Overtime);
                    }

                    sw.WriteLine("");
                    sw.WriteLine("Allowance: ${0}",stf.TotalPay); 
                    sw.Close();
                }
            }
        }

     

    }
}