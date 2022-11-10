using System;
namespace alat_kiddies_iOS1
{
    public class ParentTransaction
    {
        public ParentTransaction()
        {
        }

        public string transactionType { get; set; }
        public decimal transactionAmount { get; set; }
        public string transactionRecipientAccount { get; set; }
        public string transactionDate { get; set; }

        public ParentTransaction(string type, decimal transAmount, string recipientAcc, string transRecipientAcc, string transDate)
        {
            this.transactionAmount = transAmount;
            this.transactionType = type;
            this.transactionRecipientAccount = recipientAcc;
            this.transactionDate = transDate;
        }
                
    }
}
