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

            #region buttons array
            //Button[] buttons = new Button[8];
            //buttons[0] = homePageBtn;
            //buttons[1] = addTransactionBtn;
            //buttons[2] = transactionListbtn;
            //buttons[3] = reportBtn;
            //buttons[4] = expensesBtn;
            //buttons[5] = capitalStatementBtn;
            //buttons[6] = settingsBtn;
            //buttons[7] = Exit;
            #endregion //initializing buttons array
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
            addTransactionBtn.IsEnabled = false;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = true;
        }

        private void HomePageBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new HomePage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = false;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = true;

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TransactionListbtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TransactionPage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = false;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = true;
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ReportPage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = false;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = true;
        }

        private void ExpensesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ExpensesPage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = false;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = true;
        }

        private void CapitalStatementBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new CapStatementPage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = false;
            settingsBtn.IsEnabled = true;
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SettingsPage();
            addTransactionBtn.IsEnabled = true;
            homePageBtn.IsEnabled = true;
            transactionListbtn.IsEnabled = true;
            ReportBtn.IsEnabled = true;
            expensesBtn.IsEnabled = true;
            capitalStatementBtn.IsEnabled = true;
            settingsBtn.IsEnabled = false;
        }
    }
}
