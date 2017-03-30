//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDH.FxSignalPro.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Signal
    {
        public Signal()
        {
            this.Comments = new HashSet<Comment>();
            this.UserSignalLikes = new HashSet<UserSignalLike>();
            this.UserSignals = new HashSet<UserSignal>();
        }
    
        public System.Guid SignalId { get; set; }
        public System.Guid SellerProfileId { get; set; }
        public System.Guid CurrencyPairId { get; set; }
        public System.Guid SupportedSellCurrencyId { get; set; }
        public System.Guid TimeFrameId { get; set; }
        public System.DateTime ExpectedStartDate { get; set; }
        public System.DateTime ExpectedEndDate { get; set; }
        public decimal StopLoss { get; set; }
        public decimal EntryPoint { get; set; }
        public decimal TakeProfit { get; set; }
        public decimal SellingAmount { get; set; }
        public string PreSaleDescription { get; set; }
        public string PostSaleDescription { get; set; }
        public bool IsPublished { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Deleted { get; set; }
        public System.DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual CurrencyPair CurrencyPair { get; set; }
        public virtual SellerProfile SellerProfile { get; set; }
        public virtual SupportedSellingCurrency SupportedSellingCurrency { get; set; }
        public virtual TimeFrame TimeFrame { get; set; }
        public virtual ICollection<UserSignalLike> UserSignalLikes { get; set; }
        public virtual ICollection<UserSignal> UserSignals { get; set; }
    }
}