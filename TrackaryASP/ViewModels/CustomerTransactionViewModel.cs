﻿using System.Collections.Generic;
using TrackaryASP.Models;

namespace TrackaryASP.ViewModels
{
    /// <summary>
    /// For displaying a Customer's details with their associated Transactions.
    /// </summary>
    public class CustomerTransactionViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}