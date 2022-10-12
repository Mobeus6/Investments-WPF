using System;
using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using WPFInvestment.Classes;
using Page = System.Windows.Controls.Page;

namespace WPFInvestment.Pages
{
    /// <summary>
    /// Interaction logic for TransactionPage.xaml
    /// </summary>
    public partial class TransactionPage : Page
    {
        private readonly string Path = $"{Environment.CurrentDirectory}\\transactionsList.json";
        private BindingList<Transaction> transactions;
        private IOModel IOservice;
        public TransactionPage()
        {
            InitializeComponent();
        }

        private void addSellTransactionBtn_Click(object sender, RoutedEventArgs e)
        {

         
        }

        private void addBuyTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            IOservice = new IOModel(Path);
            try {
                float.TryParse(tokenQuantity.Text, out float tbVolume);
                float.TryParse(tokenPrice.Text, out float tbPrice);
                DateTime.TryParse(dateOfTransaction.Text, out DateTime tbDate);
                IOservice.LoadData();
                int Id = 0;
                //try
                //{
                //    foreach (Transaction transaction in transactions)
                //    {
                //        if (transaction.ID > Id)
                //        {
                //            Id = transaction.ID;
                //        }
                //    }
                //}
                //catch
                //{
                //    string nul = "nul";
                //    transactions.Add(new Transaction(0, DateTime.Now, nul, 0, 0));
                //}
                Transaction currentTransaction = new Transaction(Id, tbDate, tokenName.Text, tbVolume, tbPrice);
                transactions.Add(currentTransaction);
                IOservice.SaveData(transactions);
            }
            catch { MessageBox.Show("Please enter numbers in Token Quantity"); }
        }
    }
}
