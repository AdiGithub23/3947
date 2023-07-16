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
using System.Windows.Navigation;

namespace EG_2020_3947.View
{
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            DataContext = new DashBoardVM();
            InitializeComponent();
        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
