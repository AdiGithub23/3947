using EG_2020_3947.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EG_2020_3947.View
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent(AddStudentVM newVM)
        {
            InitializeComponent();
            DataContext = newVM;
            //newVM.CloseAction = () => Close();
        }
    }
}
