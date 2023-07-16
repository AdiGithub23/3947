using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EG_2020_3947.Model
{
    public class Student_Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public int NIC { get; set; }
        public string EMAIL { get; set; }
        public string ContactNo { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
        public BitmapImage ImgName { get; set; }
        public String ImagePath
        {
            get { return $"/Model/Assets/{ImgName}"; }
            //get { string image_Name = $"/Models/ImgNames/{ImgName}"; return image_Name; }
        }

        // C O N S T R U C T O R    T O    I N I T I A L I Z E
        public Student_Model(string fName, string lName, string dob, int age, int nic, string email, string contctno, string department, BitmapImage img)
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
            Age = age;
            NIC = nic;
            EMAIL = email;
            ContactNo = contctno;
            Department = department;
            ImgName = img;
        }

        public Student_Model()
        {
        }                           // Empty

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }


    }
}
