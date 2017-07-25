using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMvvm.Model;

namespace XamarinMvvm.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        public EmployeeViewModel()
        {
            EmployeeObject = new Employee();
        }

        #region Properties
        private Employee employeeObject;
        /// <summary>
        /// Gets or sets the employee object.
        /// </summary>
        /// <value>The employee object.</value>
        public Employee EmployeeObject
        {
            get 
            { return employeeObject; 
            }
            set {
                employeeObject = value; OnPropertyChanged();
            }
        }
		#endregion

		#region DelegateCommand
		Command SaveCommandCommand;
        /// <summary>
        /// Gets the save command.
        /// </summary>
        /// <value>The save command.</value>
		public Command SaveCommand
		{
			get
			{
				return SaveCommandCommand ?? (SaveCommandCommand = new Command(async () => await ExecuteOnEmployeeSave()));
			}
		}
        #endregion

        #region Methods 

        private async Task ExecuteOnEmployeeSave()
        {
            var empData = EmployeeObject;
        }

        #endregion
    }
}
