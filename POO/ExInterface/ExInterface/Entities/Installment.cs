using System;
using System.Collections.Generic;
using System.Text;

namespace ExInterface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            this.amount = amount;
        }
    }
}
