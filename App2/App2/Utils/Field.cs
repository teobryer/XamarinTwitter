using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.Utils
{
    public class Field<T> : INotifyPropertyChanged
    {
        // public T Value { get; set; }
        //public bool IsValid { get; set; }
        //public string ErrorMessage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        private T val;
        public T Value
        {
             set
            {

                val = value;
                OnPropertyChanged("Value");

            }
            get { return val; }
        }


        private bool isValid;
        public bool IsValid
        {
             set
            {

                isValid = value;
                OnPropertyChanged("IsValid");

            }
            get { return isValid; }
        }


        private string errorMessage;
        public string ErrorMessage
        {
             set
            {

                errorMessage = value;
                OnPropertyChanged("ErrorMessage");

            }
            get { return errorMessage; }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
