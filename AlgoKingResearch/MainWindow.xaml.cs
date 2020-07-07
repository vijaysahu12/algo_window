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

namespace AlgoKingResearch
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

        private void btn_ShutDown(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Do you want to shutdown?", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                    App.Current.Windows[intCounter].Close();
            }
        }

        private void Button_Click(object secnder, RoutedEventArgs e)
        {
            //int index = int.Parse(((Button)e.Source).Uid);
            //GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            //switch (index)
            //{
            //    case 0:
            //        GridMain.Background = Brushes.Aquamarine;
            //        break;
            //    case 1:
            //        GridMain.Background = Brushes.Beige;

            //        break;
            //    case 2:
            //        GridMain.Background = Brushes.CadetBlue;

            //        break;
            //    case 3:
            //        GridMain.Background = Brushes.DarkBlue;
            //        break;
            //    case 4:
            //        GridMain.Background = Brushes.Firebrick;
            //        break;
            //    case 5:
            //        GridMain.Background = Brushes.Gainsboro;
            //        break;
            //}
        }

        private void btn_Mapping(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Mapping");
        }

        private void btn_Code(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Code page");
        }

        private void btn_ManualOrder(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Manual Order");
        }

        private void btn_TestOrder(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Test Order");
        }

        private void btn_About(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("About");
        }

        private void btn_Email(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Email");

        }

        private void btn_Settings(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings");

        }

        private void btn_Risk(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Risk");

        }

        private void btn_Money(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Money");

        }

        private void btn_Time(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Time");

        }

        private void btn_Start(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start");

        }

        private void btn_AddUser(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("User");
        }

        private void btn_Stop(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stop algo");
        }
    }
}
