﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace BookLibrary_WPF.ViewModels
{
    public abstract class BasisViewModel : IDataErrorInfo, INotifyPropertyChanged, ICommand
    {
        #region IDataErrorInfo
        public abstract string this[string columnName] { get; }
        public string Error
        {
            get
            {
                string foutmeldingen = "";
                foreach (var item in this.GetType().GetProperties())
                {
                    string fout = this[item.Name];
                    if (!string.IsNullOrWhiteSpace(fout))
                    {
                        foutmeldingen += fout + Environment.NewLine;
                    }
                }
                return foutmeldingen;
            }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region ICommand
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

        #endregion

        #region methode: IsGeldig()
        public bool IsGeldig()
        {
            return string.IsNullOrWhiteSpace(Error);
        }
        #endregion
    }
}
