using System;
namespace Project_Csharp_Payroll
{
    public class Admin : Staff
    {
        private const float _overtimeRate = 15.5F;
        private const float _adminHourRate = 30F;

        public float Overtime{
            get;
            private set;
        }

        public Admin(string name) : base(name, _adminHourRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            if(HoursWorked > 160){
                Overtime = _overtimeRate * (HoursWorked -160);
                TotalPay = TotalPay + Overtime;
            }
        }

    

        public override string ToString()
        {
            return base.ToString()+" "+_overtimeRate+" "+ _adminHourRate;
        }
    }

}