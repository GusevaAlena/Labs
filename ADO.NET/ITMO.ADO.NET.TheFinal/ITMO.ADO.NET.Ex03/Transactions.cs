//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITMO.ADO.NET.Ex03
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public long TransactionId { get; set; }
        public long CustomerId { get; set; }
        public int TransactionType { get; set; }
        public System.DateTime DateEntered { get; set; }
        public decimal Amount { get; set; }
        public string ReferenceDetails { get; set; }
        public string Notes { get; set; }
        public Nullable<long> RelatedShareId { get; set; }
        public long RelatedProductId { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Shares Shares { get; set; }
    }
}