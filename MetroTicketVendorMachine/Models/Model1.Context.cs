﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MetroTicketEntities : DbContext
    {
        public MetroTicketEntities()
            : base("name=MetroTicketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer_Card> Customer_Card { get; set; }
        public virtual DbSet<PriceOfTicket> PriceOfTickets { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Ticket_Transaction> Ticket_Transaction { get; set; }
    }
}
