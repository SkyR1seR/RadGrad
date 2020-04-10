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

namespace RadGrad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] number { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            number = new string[] { "Градусы", "Радианы"};

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ConvSelect.SelectedItem == "Радианы")
            {
                Result.Text = Convert.ToString(Radians(Znachenie.Text));
            }
            if (ConvSelect.SelectedItem == "Градусы")
            {
                Result.Text = Convert.ToString(Gradus(Znachenie.Text));
            }
        }

        public double Radians(object a)
        {
            return (Convert.ToInt32(a) * Math.PI / 180);
        }
        public double Gradus(object a)
        {
            return (Convert.ToInt32(a) * 180 / Math.PI);
        }

        private void ConvSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ConvSelect.SelectedItem == "Радианы")
            {
                Rad.Text = "°";
                Grad.Text = "Рад";
            }
            if (ConvSelect.SelectedItem == "Градусы")
            {
                Rad.Text = "Рад";
                Grad.Text = "°";
            }
        }
    }
}
