//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.Ticket_Transaction = new HashSet<Ticket_Transaction>();
        }
    
        public int PId { get; set; }
        public int TId { get; set; }
        public int CardId { get; set; }
    
        public virtual Customer_Card Customer_Card { get; set; }
        public virtual PriceOfTicket PriceOfTicket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket_Transaction> Ticket_Transaction { get; set; }
    }
}
