using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EG_2020_3947.Model;
using EG_2020_3947.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace EG_2020_3947.ViewModel
{
    public partial class DashBoardVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student_Model> studentList;   // Link : 'Student_Model' Class

        [ObservableProperty]
        public Student_Model? selectedUser = null;


        [RelayCommand]                                           // A D D    B U T T O N
        public void AddNew()                                     // Function Call : Add a New Student
        {
            var newVM = new AddStudentVM
            {
                Title = "ADD NEW STUDENT"
            };                                                   // Link : Constructor of the 'AddStudentVM' Class
            AddStudent addwindow = new AddStudent(newVM);        // Window : Add a New Student
            //addwindow.Show();
            addwindow.ShowDialog();

            if (newVM.Student.FirstName != null)
            {
                StudentList.Add(newVM.Student);
            }
        }

        [RelayCommand]
        public void RemoveAt()                                   // Function Call : Delete a Student
        {
            if (selectedUser != null)
            {
                studentList.Remove(selectedUser);
            }
        }

        [RelayCommand]
        public void ModifyCurrent()                              // Function Call : Edit a Student
        {
            if (selectedUser != null)
            {
                var newVM = new AddStudentVM(selectedUser);
                newVM.title = "MODIFY STUDENT INFORMATION";

                var window = new AddStudent(newVM);              // New Add iStudent Window with Current Student Info
                window.ShowDialog();                             // Window : Edit Student
                int userindx = studentList.IndexOf(selectedUser);
                studentList.Insert(userindx, newVM.Student);
                studentList.RemoveAt(userindx + 1);
            }
        }

        public void CloseWindow()                                // Function Call : Close the Main Window
        {
            Application.Current.MainWindow.Close();
        }

        public DashBoardVM()
        {
            studentList = new ObservableCollection<Student_Model>();

            // T E M P L A T E

            BitmapImage img1 = new BitmapImage(new Uri("/Model/Assets/01.png", UriKind.Relative));
            studentList.Add(new Student_Model("Adheesha", "Gunathilake", "23/05/1999", 24, 991441174, "adhi@gmail.com", "0720898440", "COM", img1));
        }


        





    }
}

