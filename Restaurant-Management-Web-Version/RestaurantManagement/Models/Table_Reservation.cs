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
    
    public partial class Table_Reservation
    {
        public int Reservation_id { get; set; }
        public int Table_Cart_id { get; set; }
        public int Table_Id { get; set; }
    
        public virtual Table_Details Table_Details { get; set; }
        public virtual Table_Cart_Make Table_Cart_Make { get; set; }
    }
}
