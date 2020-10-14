using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xam.MVVM.Models
{
    public class Employee : INotifyPropertyChanged
    {
        #region Properties
        public byte EmployeeId { get; set; }        
        //public string Name { get; set; }
        public string Surname { get; set; }
        
        /// <summary>
        /// this encapsulation and PropertyChanged event for updated operation
        /// </summary>
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
