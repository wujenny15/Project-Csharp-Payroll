using System;
namespace Project_Csharp_Payroll
{
    public class Staff
    {
        private float hourlyRate;
        private int hWorked;
        private float totalPay;

        public float TotalPay { get; protected set; }

        public float BasicPay
        {
            get
            {
                return hourlyRate * hWorked;
            }
            private set { }
        }

        public string NameOfStaff
        {
            get;
            private set;
        }

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                {
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            totalPay = BasicPay;
        }

        public override string ToString()
        {
            return String.Format("{0}, hourly rate: {1}, hours worked:{2}, Basic Pay:{3}, Total Pay:{4} ", NameOfStaff, hourlyRate, HoursWorked, BasicPay, TotalPay);
        }
    }

}