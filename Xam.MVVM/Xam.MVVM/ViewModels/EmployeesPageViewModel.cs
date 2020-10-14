using System.Collections.ObjectModel;
using System.Windows.Input;
using Xam.MVVM.Models;
using Xamarin.Forms;

namespace Xam.MVVM.ViewModels
{
    public class EmployeesPageViewModel
    {
        ICommand deleteCommand, updateCommand;
        private ObservableCollection<Employee> _employees;

        public EmployeesPageViewModel()
        {
            BindData();
            deleteCommand = new Command(OnDelete);
            updateCommand = new Command(OnUpdate);
        }

        private void BindData()
        {
            Employees.Clear();
            Employees.Add(new Employee
            {
                EmployeeId = 1,
                Name = "Mustafa",
                Surname = "Dikyar"
            });

            Employees.Add(new Employee
            {
                EmployeeId = 2,
                Name = "Kemal",
                Surname = "Saygı"
            });

            Employees.Add(new Employee
            {
                EmployeeId = 3,
                Name = "Mehmet",
                Surname = "Çelebi"
            });
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                if (_employees == null)
                    _employees = new ObservableCollection<Employee>();

                return _employees;
            }

            set => _employees = value;
        }

        public ICommand DeleteCommand
        {
            get => deleteCommand;
            set
            {
                if (DeleteCommand.Equals(null))
                    return;

                deleteCommand = value;
            }
        }
        public ICommand UpdateCommand
        {
            get => updateCommand;
            set
            {
                if (updateCommand.Equals(null))
                    return;

                updateCommand = value;
            }
        }

        private void OnDelete(object param)
        {
            Employee selected = param as Employee;

            if (!selected.Equals(null))
                Employees.Remove(selected);

        }

        private void OnUpdate(object param)
        {
            Employee selected = param as Employee;

            if (selected != null)
                selected.Name = $"edited {selected.Name}";
        }
    }
}
