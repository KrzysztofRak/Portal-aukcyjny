//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bidders
    {
        public int Id { get; set; }
        public System.Guid BidderId { get; set; }
        public int AuctionId { get; set; }
        public decimal Price { get; set; }
        public System.DateTime BidDate { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual Auctions Auctions { get; set; }
    }
}
