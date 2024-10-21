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

namespace majmyl
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
        private void Bac_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem.Tag != null)
            {
                var color = menuItem.Tag.ToString();
                switch (color)
                {
                    case "Red":
                        Background = System.Windows.Media.Brushes.Red;
                        break;
                    case "Green":
                        Background = System.Windows.Media.Brushes.Green;
                        break;
                    case "Blue":
                        Background = System.Windows.Media.Brushes.Blue;
                        break;
                }
            }


        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Raz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Нурия");
        }
    }
}





