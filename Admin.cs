namespace Project_Csharp_Payroll
{
    public class Admin : Staff
    {
        private const float overtimeRate = 15.5F;
        private const float adminHourRate = 30F;

        public float Overtime
        {
            get;
            private set;
        }

        public Admin(string name) : base(name, adminHourRate)
        {
        }

        public override void CalculatePay()
        {
            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = BasicPay + Overtime;
            }
            else
            {
                Overtime = 0;
                TotalPay = BasicPay;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Overtime Pay:" + Overtime;
        }
    }
}