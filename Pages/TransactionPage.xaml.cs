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

        /// <summary>
        /// Adding sell transaction to JSON file on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSellTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             IOservice = new IOModel(Path); //initializing new IO model
 
             transactions = new BindingList<Transaction>(); //initializing new list for transactions

             transactions = IOservice.LoadData(); //loading all data from JSON file to new list

             Transaction currentTransactionS = new Transaction(); //initializing new transaction class
 
             bool tokenQParseDone = float.TryParse(tokenQuantity.Text, out float stbVolume);
             if (tokenQParseDone) currentTransactionS.volume = stbVolume;                         
             else STokenQuantityEx.Text = "Please enter numbers here";

             bool tokenPParseDone = float.TryParse(tokenPrice.Text, out float stbPrice);
             if (tokenPParseDone) currentTransactionS.price = stbPrice;
             else SPriceEx.Text = "Please enter numbers here";

             bool dateParseDone = DateTime.TryParse(dateOfTransaction.Text, out DateTime stbDate); 
             if (dateParseDone) currentTransactionS.date = stbDate;
             else SDateParsingEx.Text = "Please enter date dd/mm/yyyy";

             currentTransactionS.pair = tokenName.Text;
             currentTransactionS.transactionType = "S";

           
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
            catch (Exception ex) { /*MessageBox.Show($"{ex}");*/ }

        }

        /// <summary>
        /// Adding buy transaction to JSON file on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBuyTransactionBtn_Click(object sender, RoutedEventArgs e)
        {
            IOservice = new IOModel(Path); //initializing new IO model

            transactions = new BindingList<Transaction>(); //initializing new list for transactions

            transactions = IOservice.LoadData(); //loading all data from JSON file to new list

            Transaction currentTransaction = new Transaction(); //initializing new transaction class

            try
            {

              bool tokenQParseDone = float.TryParse(tokenQuantity.Text, out float tbVolume);
             if (tokenQParseDone) currentTransaction.volume = tbVolume;
             else TokenQuantityEx.Text = "Please enter numbers here";

             bool tokenPParseDone = float.TryParse(tokenPrice.Text, out float tbPrice);
             if (tokenPParseDone) currentTransaction.price = tbPrice;
             else PriceEx.Text = "Please enter numbers here";

             bool dateParseDone = DateTime.TryParse(dateOfTransaction.Text, out DateTime tbDate);
             if (dateParseDone) currentTransaction.date = tbDate;
             else DateParsingEx.Text = "Please enter date dd/mm/yyyy";
 
             currentTransaction.pair = tokenName.Text;
             currentTransaction.transactionType = "B";
           
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
            catch (Exception ex) { /*MessageBox.Show($"{ex}");*/ }
             
        }
    }
}
