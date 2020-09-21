namespace Project_Csharp_Payroll
{
    public class Staff{
        private float _hourlyRate;
        private int _hWorked; 
        private float _totalPay;

        public float TotalPay{
            get{
                return _hourlyRate * _hWorked;
            }

            protected set{
                _totalPay = _hourlyRate + _hWorked;
            }
        }
        
        public float BasicPay{
            get{
                return _hourlyRate *_hWorked;
            }

            private set{
                _totalPay = _hourlyRate +_hWorked;
            }
        }

        public string NameOfStaff{
            get{
                return "null";
            }

            private set{

            }
        }

        public int HoursWorked{
            get{
                return _hWorked;
            }
            set{
                if(value >=10){

                }else{
                    
                }
            }
        }

    }


}