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

        private void AddSellTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            IOservice = new IOModel(Path); //initializing new IO model

            transactions = new BindingList<Transaction>(); //initializing new list for transactions

            transactions = IOservice.LoadData(); //loading all data from JSON file to new list for ID
            Transaction currentTransactionS = new Transaction();
            try { float.TryParse(tokenQuantity.Text, out float stbVolume); currentTransactionS.volume = stbVolume; }
            catch { TokenQuantityEx.Text = "Please enter numbers here"; }
            try { float.TryParse(tokenPrice.Text, out float stbPrice); currentTransactionS.price = stbPrice; }
            catch { PriceEx.Text = "Please enter numbers here"; }
            try { DateTime.TryParse(dateOfTransaction.Text, out DateTime stbDate); currentTransactionS.date = stbDate; }
            catch { DateParsingEx.Text = "Please enter data in format dd/mm/yyyy"; }
            currentTransactionS.pair = tokenName.Text;
            try
            {
                int Id = 0;
                foreach (Transaction transaction in transactions)
                {
                    if (transaction.ID > Id)
                    {
                        Id = transaction.ID;
                    }
                    Id++;
                }
                currentTransactionS.ID = Id;
                transactions.Add(currentTransactionS);
                IOservice.SaveData(transactions);
                InputDone.Text = "Successfully added";
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }

        }

        private void AddBuyTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            IOservice = new IOModel(Path); //initializing new IO model

            transactions = new BindingList<Transaction>(); //initializing new list for transactions

            transactions = IOservice.LoadData(); //loading all data from JSON file to new list for ID
            Transaction currentTransaction = new Transaction();
            try { float.TryParse(tokenQuantity.Text, out float tbVolume); currentTransaction.volume = tbVolume; }
            catch { TokenQuantityEx.Text = "Please enter numbers here"; }
            try { float.TryParse(tokenPrice.Text, out float tbPrice); currentTransaction.price = tbPrice; }
            catch { PriceEx.Text = "Please enter numbers here"; }
            try { DateTime.TryParse(dateOfTransaction.Text, out DateTime tbDate); currentTransaction.date = tbDate; }
            catch { DateParsingEx.Text = "Please enter data in format dd/mm/yyyy"; } 
            currentTransaction.pair = tokenName.Text; 
            try
            {
                int Id = 0;
              foreach (Transaction transaction in transactions)
              {
                 if (transaction.ID > Id)
                 {
                   Id = transaction.ID;
                 }
                    Id++;
              }
                currentTransaction.ID = Id;
                transactions.Add(currentTransaction);
                IOservice.SaveData(transactions);
                InputDone.Text = "Successfully added";
            }
            catch (Exception ex){ MessageBox.Show($"{ex}"); }
             
        }
    }
}
