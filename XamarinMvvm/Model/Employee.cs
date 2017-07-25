using System;
namespace XamarinMvvm.Model
{
    public class Employee:BaseModel
    {
      
        public string EmployeeId
        {
            get;
            set;
        }

        public string EmployeeName
        {
            get;
            set;
        }

        public string EmployeeAddress
        {
            get;
            set;
        }
    }
}
