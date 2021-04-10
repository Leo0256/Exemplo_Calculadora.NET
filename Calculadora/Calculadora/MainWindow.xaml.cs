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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class Teste : Window
    {

        public Teste()
        {
            InitializeComponent();
        }

        bool Empty()
        {
            bool empty = true;

            if (num1.Text.Equals("") || num2.Text.Equals(""))
            {
                empty = false;
            }

            result.Clear();
            return empty;
        }

        private void Soma(object sender, RoutedEventArgs e)
        {
            if (Empty())
            {
                result.Text = String.Format(
                    "{0}", Double.Parse(num1.Text) + Double.Parse(num2.Text));
                num1.Clear();
                num2.Clear();
            }
        }

        private void Sub(object sender, RoutedEventArgs e)
        {
            if (Empty())
            {
                result.Text = String.Format(
                    "{0}", Double.Parse(num1.Text) - Double.Parse(num2.Text));
                num1.Clear();
                num2.Clear();
            }
        }

        private void Mult(object sender, RoutedEventArgs e)
        {
            if (Empty())
            {
                result.Text = String.Format(
                    "{0}", Double.Parse(num1.Text) * Double.Parse(num2.Text));
                num1.Clear();
                num2.Clear();
            }
        }

        private void Div(object sender, RoutedEventArgs e)
        {
            if (Empty())
            {
                if (Double.Parse(num2.Text) == 0)
                {
                    result.Text = "NaN";
                }
                else
                {
                    result.Text = String.Format(
                        "{0}", Double.Parse(num1.Text) / Double.Parse(num2.Text));
                    num1.Clear();
                    num2.Clear();
                }
            }
        }
    }
}
