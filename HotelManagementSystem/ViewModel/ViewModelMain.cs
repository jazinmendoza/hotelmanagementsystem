﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MvvmExample.Model;
using MvvmExample.Helpers;

namespace MvvmExample.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Person> People { get; set; }

        object _SelectedPerson;
        public object SelectedPerson
        {
            get
            {
                return _SelectedPerson;
            }
            set
            {
                if (_SelectedPerson != value)
                {
                    _SelectedPerson = value;
                    RaisePropertyChanged("SelectedPerson");
                }
            }
        }

        string _TextProperty1;
        public string TextProperty1
        {
            get
            {
                return _TextProperty1;
            }
            set
            {
                if (_TextProperty1 != value)
                {
                    _TextProperty1 = value;
                    RaisePropertyChanged("TextProperty1");
                }
            }
        }

        public RelayCommand AddUserCommand { get; set; }

        public ViewModelMain()
        {
            People = new ObservableCollection<Person>
            {
                new Person { FirstName="Tom", LastName="Jones", Age=80 },
                new Person { FirstName="Dick", LastName="Tracey", Age=40 },
                new Person { FirstName="Harry", LastName="Hill", Age=60 },
            };
            TextProperty1 = "Type here";

            AddUserCommand = new RelayCommand(AddUser);
        }

        void AddUser(object parameter)
        {
            if (parameter == null) return;
            People.Add(new Person { FirstName = parameter.ToString(), LastName = parameter.ToString(), Age = DateTime.Now.Second });
        }

    }
}
