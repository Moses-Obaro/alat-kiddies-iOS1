using System;
namespace alat_kiddies_iOS1
{
    public class WardTransactions
    {
        public WardTransactions()
        {
        }

        public string transactionUniqueReference { get; set; }
        public decimal transactionAmount { get; set; }
        public string transactionSourceAccount { get; set; }
        public string transactionDestinationAccount { get; set; }
        public DateTime transactionDate { get; set; }

        public WardTransactions(string transID, decimal transAmount, string transSourceAcc, string transRecipientAcc, DateTime transDate)
        {
            this.transactionAmount = transAmount;
            this.transactionUniqueReference = transID;
            this.transactionSourceAccount = transSourceAcc;
            this.transactionDestinationAccount = transRecipientAcc;
            this.transactionDate = transDate;
        }
    }
}
