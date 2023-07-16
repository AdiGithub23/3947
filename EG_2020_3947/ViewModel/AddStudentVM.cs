using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EG_2020_3947.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace EG_2020_3947.ViewModel
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public string firstname;
        [ObservableProperty]
        public string lastname;
        [ObservableProperty]
        public string dateofbirth;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public int nic;
        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string contact;
        [ObservableProperty]
        public string department;
        [ObservableProperty]
        public double gpa;
        [ObservableProperty]
        public string title;            // Add New Student_Model Window : Title
        [ObservableProperty]
        public BitmapImage selectedImage;

        public AddStudentVM(Student_Model stud)    // Constructor
        {
            Student = stud;
            firstname = Student.FirstName;
            lastname = Student.LastName;
            dateofbirth = Student.DateOfBirth;
            age = Student.Age;
            nic = Student.NIC;
            email = Student.EMAIL;
            contact = Student.ContactNo;
            department = Student.Department;
            gpa = Student.GPA;
            selectedImage = Student.ImgName;
        }
        public AddStudentVM()
        {
        }           // Empty

        public Student_Model Student { get; private set; }

        [RelayCommand]
        public void InsertImage()
        {
            OpenFileDialog popupWindow = new OpenFileDialog();
            popupWindow.Filter = "Image files | *.bmp; *.jpg; *.png;";
            popupWindow.FilterIndex = 2;
            if (popupWindow.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(popupWindow.FileName));
            }
        }

        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {
            if (age >= 30)
            {
                MessageBox.Show("This Student is too Old. Check Again!", "E R R O R");
                return;
            }
            if (gpa > 4)
            {
                MessageBox.Show("Invalid GPA. Check Again!", "E R R O R");
                return;
            }                           // Invalid GPA. Check Again!", "E R R O R"
            if (Student == null)
            {
                Student = new Student_Model()                // Link : Constructor of the 'iStudent' Class
                {
                    FirstName = firstname,
                    LastName = lastname,
                    DateOfBirth = dateofbirth,
                    Age = age,
                    NIC = nic,
                    EMAIL = email,
                    ContactNo = contact,
                    Department = department,
                    GPA = gpa,
                    ImgName = selectedImage
                };
            }
            else
            {
                Student.FirstName = firstname;
                Student.LastName = lastname;
                Student.DateOfBirth = dateofbirth;
                Student.Age = age;
                Student.NIC = nic;
                Student.EMAIL = email;
                Student.ContactNo = contact;
                Student.Department = department;
                Student.GPA = gpa;
                Student.ImgName = selectedImage;
            }

            if (Student.FirstName != null)
            {
                CloseAction();
            }

            Application.Current.MainWindow.Show();  // Back To Main Window
        }

        //[RelayCommand]
        //public void MinimizeWindow()
        //{
        //    Application.Current.MainWindow.WindowState = WindowState.Minimized;
        //}

        //[RelayCommand]
        //public void CloseWindow()
        //{
        //    Application.Current.MainWindow.Close();
        //}

    }
}
