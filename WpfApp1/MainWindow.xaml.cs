using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            num1.Text = string.Empty;
            den1.Text = string.Empty;
            num2.Text = string.Empty;
            den2.Text = string.Empty;
            numAns.Content = string.Empty;
            denAns.Content = string.Empty;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(num1.Text, out int a1);
            int.TryParse(den1.Text, out int d1);
            int.TryParse(num2.Text, out int a2);
            int.TryParse(den2.Text, out int d2);


            numAns.Content = a1 + d1;
            denAns.Content = a2 * d2;

        }
    }
}