using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project_Csharp_Payroll {
    public class PaySlip {

        private int month;
        private int year;

        enum MonthOfYear {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }

        public PaySlip (int payMonth, int payYear) {
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip (List<Staff> myStaff) {
            string path;
            foreach (Staff stf in myStaff) {
                path = stf.NameOfStaff + ".txt";
                using (StreamWriter sw = new StreamWriter (path)) {
                    sw.WriteLine ("PAYSLIP FOR {0} {1}", month, year);
                    sw.WriteLine ("=============================");
                    sw.WriteLine ("Name of Staff: {0}", stf.NameOfStaff);
                    sw.WriteLine ("Hours Worked: {0}", stf.HoursWorked);
                    sw.WriteLine ("");
                    sw.WriteLine ("Basic Pay: ${0}", stf.BasicPay);
                    //TODO: Cast the Object into dynamic type
                    if (stf is Manager) {
                        sw.WriteLine ("Allowacne: ${0}", ((Manager) stf).Allowance);
                    }

                    if (stf is Admin) {
                        sw.WriteLine ("Overtime: {0}", ((Admin) stf).Overtime);
                    }

                    sw.WriteLine ("");
                    sw.WriteLine ("Allowance: ${0}", stf.TotalPay);
                    sw.Close ();
                }
            }
        }

        public void GenerateSummary (List<Staff> myStaff) {
            var staff = myStaff.Where (s => s.HoursWorked < 10).Select (s => new { s.NameOfStaff, s.HoursWorked }).OrderBy (s => s.NameOfStaff);
            string path = "summary.txt";

            using (StreamWriter sw = new StreamWriter (path)) {
                sw.WriteLine ("Staff with less than 10 working hours");
                sw.WriteLine (" ");
                foreach (var stf in staff) {
                    sw.WriteLine ("Name of Staff: {0}, Hours Worked: {1}", stf.NameOfStaff, stf.HoursWorked);
                }
                sw.Close ();
            }

        }

        public override string ToString () {
            return base.ToString () + " "+month + ""+year;
        }
    }
}