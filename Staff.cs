using System;
namespace Project_Csharp_Payroll {
    public class Staff {
        private float _hourlyRate;
        private int _hWorked;
        private float _totalPay;

        public float TotalPay {
            get {
                return _hourlyRate * _hWorked;
            }

            protected set {
                _totalPay = _hourlyRate + _hWorked;
            }
        }

        public float BasicPay {
            get {
                return _hourlyRate * _hWorked;
            }

            private set {} 

        }

        public string NameOfStaff {
            get;
            private set;
        }

        public int HoursWorked {
            get {
                return _hWorked;
            }
            set {
                if (value > 0) {
                    _hWorked = value;
                } else {
                    _hWorked = 0;
                }
            }
        }

        public Staff (string name, float rate) {
            NameOfStaff = name;
            _hourlyRate = rate;
        }

        public virtual void CalculatePay () {
            Console.WriteLine ("Calculating Pay...");
            BasicPay = _hWorked * _hourlyRate;
            _totalPay = BasicPay;
        }

        public override string ToString () {
            return  String.Format("Staff: {0}, hourly rate: {1}, hours worked:{2}, Basic Pay:{3}, Total Pay:{4} ", NameOfStaff, _hourlyRate, HoursWorked, BasicPay, TotalPay);
        }
    }

}