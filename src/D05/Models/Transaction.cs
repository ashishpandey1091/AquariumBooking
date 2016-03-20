using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace D05.Models
{
    public class Transaction
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        public int TransactionID { get; set; }


        public DateTime CreatedDate { get; set; }
        
        
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public string UsedCoupon { get; set; }


       

        // Navigation property
        [RegularExpression(" ^ ([0 - 9a - zA - Z]([-\\.\\w] *[0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w] *[0 - 9a - zA - Z]\\.)+[a-zA-Z]{2,9})$",ErrorMessage = "Invalid email.")]
        public string  CreatedByEmail { get; set; }

        public static List<Transaction> ReadAllFromCSV(string filepath)
        {
            List<Transaction> lst = File.ReadAllLines(filepath)
                                        .Skip(1)
                                        .Select(v => Transaction.OneFromCsv(v))
                                        .ToList();
            return lst;
        }

        public static Transaction OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Transaction item = new Transaction();

            int i = 0;
            item.TransactionID = Convert.ToInt32(values[i++]);
            item.CreatedDate = Convert.ToDateTime(values[i++]);
            item.CreatedByEmail = Convert.ToString(values[i++]);
            item.TotalAmount = Convert.ToDouble(values[i++]);
            item.PaidAmount = Convert.ToDouble(values[i++]);
            item.UsedCoupon = Convert.ToString(values[i++]);
            

            return item;
        }





    }
}
