using System;
namespace Project_Csharp_Payroll
{
    public class Manager : Staff
    {
        private const float managerHourlyRate = 50F;

        public int Allowance { get; set; }

        public Manager(string name) : base(name, managerHourlyRate) { }

        public override void CalculatePay()
        {
            if (HoursWorked > 160)
            {
                Allowance = 1000;
                TotalPay = BasicPay + Allowance;
            }
            else
            {
                Allowance = 0;
                TotalPay = BasicPay;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Allowance:" + Allowance;
        }
    }
}