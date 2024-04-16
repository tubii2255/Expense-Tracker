using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }

        public int CategoryID { get; set; }

        // Navigation property to the Category entity
        public Category Category { get; set; }

        // Use decimal for currency amounts
        public decimal Amount { get; set; }

        // Use nvarchar(max) for Note instead of a fixed length
        [Column(TypeName = "varchar(1000)")]
        public string? Note { get; set; }

        // Set default value to current date and time
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
