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
namespace WpfApp1;

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
        mixedNum.Content = string.Empty;
    }
    private void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        int.TryParse(num1.Text, out int a1);
        int.TryParse(den1.Text, out int d1);
        int.TryParse(num2.Text, out int a2);
        int.TryParse(den2.Text, out int d2);
        int num = 0;
        int den = 0;

        int op = opComboBox.SelectedIndex;
        switch (op)
        {
            case 0:
                num = a1 * d2 + a2 * d1;
                den = d1 * d2;
                break;
            case 1:
                num = a1 * d2 - a2 * d1;
                den = d1 * d2;
                break;
            case 2:
                num = a1 * a2;
                den = d1 * d2;
                break;
            case 3:
                num = a1 * d2;
                den = d1 * a2;
                break;
            default:
                break;
        }
        numAns.Content = num;
        denAns.Content = den;

        if (num < den)
        {
            int gcd = GCD(num, den);
            num /= gcd;
            den /= gcd;
            numAns.Content = num;
            denAns.Content = den;
        }
        else
        {
            if (num % den == 0)
            {
                mixedNum.Content = num / den;
                numAns.Content = string.Empty;
                denAns.Content = string.Empty;
            }
            else
            {
                mixedNum.Content = Mixed(num, den);
                num = num % den;
                if (num < den)
                {
                    int gcd = GCD(num, den);
                    num /= gcd;
                    den /= gcd;
                    numAns.Content = num;
                    denAns.Content = den;
                }
            }
        }
    }
    private int GCD(int a, int d)
    {
        while (a != 0)
        {
            int e = a;
            a = d % a;
            d = e;
        }
        return d;
    }
    private int Mixed(int a, int d)
    {
        int m = a / d;
        return m;
    }
}