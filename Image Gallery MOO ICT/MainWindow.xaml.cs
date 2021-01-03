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

namespace Image_Gallery_MOO_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int i = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 6;
            }

            picHolder.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            i++;

            if (i > 6)
            {
                i = 1;
            }

            picHolder.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));
        }
    }
}
