using System;
using System.Collections.Generic;
using System.Configuration;
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
using WPFInvestment.Pages;

namespace WPFInvestment
{
  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new HomePage();
           
        }
        

        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void AddTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TransactionPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new HomePage();

        }

        private void homePageBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new HomePage();
            
        }
    }
}
