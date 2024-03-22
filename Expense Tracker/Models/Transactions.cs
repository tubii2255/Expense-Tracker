﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now; 

    }
}
