using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabeledTextboxControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class LabeledTextbox : UserControl, INotifyPropertyChanged
    {
        public LabeledTextbox()
        {
            this.DataContext = this;
            InitializeComponent();

        }
        public event PropertyChangedEventHandler PropertyChanged;

        private string _fieldName;
        public string FieldName
        {
            get { return _fieldName; }
            set
            {
                _fieldName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FieldName"));
            }
        }

        private string _textValue;
        public string TextValue
        {
            get { return _textValue; }
            set { _textValue = value; }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = "";
            txtField.Focus();
        }
    }
}