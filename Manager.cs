using System;
namespace Project_Csharp_Payroll {
    public class Manager : Staff {
        private const float _managerHourlyRate = 50F;
        public Manager (string name) : base (name, _managerHourlyRate) { }

        public int Allowance { get; set; }

        public override void CalculatePay () {
           
            if (HoursWorked > 160) {
              Allowance = 1000;
              TotalPay = BasicPay + Allowance;
            }else{
                Allowance = 0;
                TotalPay = BasicPay;
            }
        }

        public override string ToString () {
            return base.ToString () + ",Allowance:" + Allowance;
        }
    }
}