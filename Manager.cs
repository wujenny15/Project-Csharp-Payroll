using System;
namespace Project_Csharp_Payroll
{
    public class Manager : Staff
    {
        private const float _managerHourlyRate =50F;
        public Manager(string name) : base(name, _managerHourlyRate)
        {
        }

        public int Allowance{get; set;}
        
        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if(HoursWorked >160){
                TotalPay = TotalPay +1000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + Allowance;
        }
    }
}