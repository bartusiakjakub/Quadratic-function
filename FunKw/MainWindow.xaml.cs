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

namespace FunKw
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content += " = " + TextBoxA.Text;
            labelB.Content += " = " + TextBoxB.Text;
            labelC.Content += " = " + TextBoxC.Text;

            int a;
            int b;
            int c;
            double d;
            double pierwiastek;
            double x0;
            double x1;
            double x2;

            a = int.Parse(TextBoxA.Text);
            b = int.Parse(TextBoxB.Text);
            c = int.Parse(TextBoxC.Text);
            d = b * b - 4 * a * c;
            pierwiastek = Math.Sqrt(d);

            labelWynikDelty.Content = +d;

            if (d < 0)
                {
                    labelIlosc.Content = "Brak miejsc zerowych";
                    labelWynikX1.Content = "Brak";
                    labelWynikX2.Content = "Brak";
                }

            else if (d == 0)
                {
                    labelIlosc.Content = "Jedno miejsce zerowe";
                    x0 = -b / (2 * a);
                    labelWynikX1.Content = +x0;
                labelWynikX2.Content = "Brak";
                }

            else if (d > 0)
                {
                labelIlosc.Content = "Dwa miejsca zerowe";
                x1 = (-b - pierwiastek) / (2 * a);
                x2 = (-b + pierwiastek) / (2 * a);
                labelWynikX1.Content = + x1;
                labelWynikX2.Content = + x2;
            }
        }

        private void TextBoxB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
