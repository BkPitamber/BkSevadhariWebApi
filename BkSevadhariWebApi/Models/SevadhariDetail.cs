//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BkSevadhariWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SevadhariDetail
    {
        public int SdId { get; set; }
        public int SmId { get; set; }
        public string ProgramName { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> DeptId { get; set; }
        public Nullable<int> MadhubanLocId { get; set; }
        public string BuildingName { get; set; }
        public string RoomNo { get; set; }
        public string HasApprovalLetter { get; set; }
        public string IsExpired { get; set; }
        public string Comments { get; set; }
        public System.DateTime CreatedModifiedOn { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual MadhubanLocation MadhubanLocation { get; set; }
        public virtual SevaDhariMaster SevaDhariMaster { get; set; }
    }
}
