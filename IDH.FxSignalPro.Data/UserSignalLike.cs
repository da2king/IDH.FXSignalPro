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
    
    public partial class UserSignalLike
    {
        public System.Guid UserId { get; set; }
        public System.Guid SignalID { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Signal Signal { get; set; }
        public virtual User User { get; set; }
    }
}
