//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Cart_Make
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Cart_Make()
        {
            this.Table_Reservation = new HashSet<Table_Reservation>();
        }
    
        public int Table_Cart_Id { get; set; }
        public int Customer_Id { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Start_time { get; set; }
        public string End_Time { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Reservation> Table_Reservation { get; set; }
    }
}
