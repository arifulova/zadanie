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

namespace majmyl2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Black_Click(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.Green;
        }


        private void Draw(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.Black;
        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            INK.DefaultDrawingAttributes.Color = Colors.White;
        }
        private void Drop(object sender, RoutedEventArgs e)
        {
            this.INK.Strokes.Clear();
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (INK != null)
            {
                INK.DefaultDrawingAttributes.Width = ((Slider)sender).Value;
                INK.DefaultDrawingAttributes.Height = ((Slider)sender).Value;
            }

        }
    }
}
