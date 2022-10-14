using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Newtonsoft.Json;


namespace WPFInvestment.Classes
{
    internal class IOModel
    {
        private readonly string Path;

        public IOModel (string path)
        { 
            Path = path;
        }

        /// <summary>
        /// Loading data from JSON file to transaction list
        /// </summary>
        /// <returns></returns>
        public BindingList<Transaction> LoadData()
        {
            var fileExsist = File.Exists(Path);
            if (!fileExsist)
            {
                File.CreateText(Path).Dispose();
                return new BindingList<Transaction>();
            }
            using(var reader = File.OpenText(Path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Transaction>>(fileText);
            }
            
        }

        /// <summary>
        /// Saving data from transaction list to JSON file
        /// </summary>
        /// <param name="transactionList"></param>
        public void SaveData(BindingList<Transaction> transactionList) 
        {
            using (StreamWriter writer = File.CreateText(Path))
            {
                string output = JsonConvert.SerializeObject(transactionList);
                writer.Write(output);
            }
        }
    }
}
