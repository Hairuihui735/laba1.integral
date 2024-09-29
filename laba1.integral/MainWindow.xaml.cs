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
using laba1.integral.classes;

namespace laba1.integral
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateIntegral();

        }
        private void CalculateIntegral()
        {
            double upperBound = Convert.ToDouble(tbUpperBound.Text);
            double lowerBound = Convert.ToDouble(tbLowerBound.Text);
            int count = Convert.ToInt32(tbCount.Text);

            Icalculator calculatorIntegral = GetCalculator();
            double answer = calculatorIntegral.Calculate(lowerBound, upperBound, count, x => (2*x)-Math.Log(2*x)+234;
            tbAnswer.Text = answer.ToString();
        }

        private Icalculator GetCalculator()
        {
            switch (cmbBoxIntegralType.SelectedIndex)
            {
                case 0:
                    return new SimpsonCalculator();
                case 1:
                    return new TrapCalculator();
                default:
                    return new SimpsonleCalculator();
            }

        }
    }
}