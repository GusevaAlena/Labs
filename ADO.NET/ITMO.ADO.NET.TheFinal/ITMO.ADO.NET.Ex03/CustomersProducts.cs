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
    
    public partial class CustomersProducts
    {
        public long CustomerFinancialProductId { get; set; }
        public long CustomerId { get; set; }
        public long FinantialProductId { get; set; }
        public decimal AmountToCollect { get; set; }
        public short Frequency { get; set; }
        public System.DateTime LastCollected { get; set; }
        public System.DateTime LastCollection { get; set; }
        public bool Renewable { get; set; }
    }
}
