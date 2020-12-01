//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DareZameen_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            this.InventoryUtlities = new HashSet<InventoryUtlities>();
            this.InventoryUtlities1 = new HashSet<InventoryUtlities>();
            this.Room = new HashSet<Room>();
        }
    
        public int Id { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> PropertyTypeId { get; set; }
        public Nullable<decimal> Size { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Demand { get; set; }
        public string Description { get; set; }
        public Nullable<int> Status { get; set; }
        public string QAComments { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<int> TotalFloors { get; set; }
        public Nullable<int> AtFloor { get; set; }
        public Nullable<int> View { get; set; }
        public Nullable<bool> IsRoofAvailable { get; set; }
        public Nullable<decimal> RoofSize { get; set; }
        public Nullable<bool> IsBasementAvailable { get; set; }
        public Nullable<decimal> BasementSize { get; set; }
        public Nullable<int> SpecialLocationId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Number { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Category Category { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual Reference Reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryUtlities> InventoryUtlities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryUtlities> InventoryUtlities1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Room { get; set; }
        public virtual SpecialLocation SpecialLocation { get; set; }
    }
}
