//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public System.Guid Id { get; set; }
        public System.Guid TraineeId { get; set; }
        public System.DateTimeOffset PaidDate { get; set; }
        public double Amount { get; set; }
        public int Method { get; set; }
        public string Note { get; set; }
        public string TransactionNumber { get; set; }
        public bool IsVerified { get; set; }
        public System.DateTimeOffset VerifiedAt { get; set; }
    
        public virtual Trainee Trainee { get; set; }
    }
}
