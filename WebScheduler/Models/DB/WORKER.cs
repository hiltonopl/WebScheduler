//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebScheduler.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class WORKER
    {
        public Nullable<System.Guid> ID { get; set; }
        public int SYSUserProfileID { get; set; }
        public int SYSUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<int> UserTypeID { get; set; }
    }
}
