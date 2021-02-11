using System;
using System.Collections.Generic;
using System.Text;
namespace EFCore.WebApi
{
    public class Transaction
    {
        public int Id { get; set; }
        public Account Beneficiary { get; set; }
        public Account Sender { get; set; }
        public int BeneficiaryAccountId { get; set; }
        public int SenderAccountId { get; set; }
        public DateTime TransferDate { get; set; }
        public decimal Amount { get; set; }
        //public List<Account> Accounts { get; set; }

    }
}