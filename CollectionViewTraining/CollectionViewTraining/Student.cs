using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace CollectionViewTraining
{
    class Student : INotifyPropertyChanged
    {
        public Student()
        {

        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int AverageScore { get; set; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
    class StudentList
    {
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students 
        { 
            get
            {
                return this.students;
            }
        }
        public StudentList()
        {
            students = new ObservableCollection<Student>();
            
            InitStudents();
        }
        private void InitStudents()
        {
            this.students.Add(new Student
            {
                FirstName = "Ofer",
                LastName = "Zadikario",
                BirthDate = new DateTime(1972, 11, 15),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Tal",
                LastName = "Simon",
                BirthDate = new DateTime(1975, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Racheli",
                LastName = "Zosiman",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Smadar",
                LastName = "Vechter",
                BirthDate = new DateTime(1965, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                FirstName = "Adi",
                LastName = "Menahem",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });

        }

        public ICommand DeleteCommand => new Command<Student>(RemoveStudent);

        void RemoveStudent(Student st)
        {
            if (students.Contains(st))
            {
                students.Remove(st);
            }
        }

    }
}
