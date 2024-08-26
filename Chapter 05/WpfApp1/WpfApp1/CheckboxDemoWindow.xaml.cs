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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CheckboxDemoWindow.xaml
    /// </summary>
    public partial class CheckboxDemoWindow : Window
    {
        public CheckboxDemoWindow()
        {
            InitializeComponent();
            
        }

        private void chkGrapes_Checked(object sender, RoutedEventArgs e)
        {
           // bool isGeapeAccepted = chkGrapes.IsChecked;
        }
    }
}
