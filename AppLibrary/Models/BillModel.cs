using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class BillModel
    {
        /// <summary>
        /// Represents the uniquie identity the bills
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the transaction number by the cashier
        /// </summary>
        public int InvoiceNumber { get; set; }
        /// <summary>
        /// Represents the amount of how much bills
        /// </summary>
        public Decimal TotalAmount { get; set; }
        /// <summary>
        /// Represents the amount of how much the costumer payed
        /// </summary>
        public Decimal PaidAmount { get; set; }
        /// <summary>
        /// Represents the amount of the change
        /// </summary>
        public Decimal Change { get; set; }
        /// <summary>
        /// Represents the date of the transaction
        /// </summary>
        public DateTime Date { get; set; }
    }
}
