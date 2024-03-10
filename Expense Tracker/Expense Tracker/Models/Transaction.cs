﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? Note { get; set; }

        public int Amount{ get; set; }

        public DateTime Date { get; set; }=DateTime.Now;

    }
}
