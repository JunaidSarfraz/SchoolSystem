//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentToFeeHead
    {
        public int HeadId { get; set; }
        public int StudentId { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual FeeHead FeeHead { get; set; }
        public virtual Student Student { get; set; }
    }
}