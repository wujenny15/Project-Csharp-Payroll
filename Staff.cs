using System;
namespace Project_Csharp_Payroll
{
    public class Staff
    {
        private float _hourlyRate;
        private int _hWorked;
        private float _totalPay;

        public float TotalPay
        {
            get
            {
                return _hourlyRate * _hWorked;
            }

            protected set
            {
                _totalPay = _hourlyRate + _hWorked;
            }
        }

        public float BasicPay
        {
            get
            {
                return _hourlyRate * _hWorked;
            }

            private set{}
            
        }

        public string NameOfStaff
        {
            get
            {
                return null;
            }

            private set
            {

            }
        }

        public int HoursWorked
        {
            get
            {
                return _hWorked;
            }
            set
            {
                if (value > 0)
                {
                    _hWorked = value;
                }
                else
                {
                    _hWorked = 0;
                }
            }
        }

        public Staff(string name, float rate){
            NameOfStaff = name;
            _hourlyRate = rate;
        }

        public virtual void CalculatePay(){
            Console.WriteLine("Calculating Pay...");
            BasicPay = _hWorked * _hourlyRate;
            _totalPay = BasicPay;
        }

        public override string ToString()
        {
            return "Staff " + _hourlyRate + " "+ _hWorked+ " "+ _totalPay +" "+ TotalPay+" "+ BasicPay+" "+NameOfStaff;
        }
    }


}