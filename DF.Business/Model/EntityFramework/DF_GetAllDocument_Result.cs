//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DF.Business.Model.EntityFramework
{
    using System;
    
    public partial class DF_GetAllDocument_Result
    {
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string Extention { get; set; }
        public string Path { get; set; }
        public Nullable<long> FolderId { get; set; }
        public string Size { get; set; }
        public Nullable<bool> IsFavourite { get; set; }
        public long UserId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> IsActive { get; set; }
    }
}