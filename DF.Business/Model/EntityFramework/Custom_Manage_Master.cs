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
    using System.Collections.Generic;
    
    public partial class Custom_Manage_Master
    {
        public long FieldId { get; set; }
        public long UserID { get; set; }
        public string Module { get; set; }
        public int Column_Id { get; set; }
        public string ActualColumnName { get; set; }
        public string Column_Label { get; set; }
        public string Column_Type { get; set; }
        public string Field_Type { get; set; }
        public string Column_Description { get; set; }
        public string HoverText { get; set; }
        public string InputDataType { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<int> DisplayPosition { get; set; }
        public Nullable<int> MaxLength { get; set; }
        public Nullable<bool> RequiredField { get; set; }
        public Nullable<bool> MultiValued { get; set; }
        public string ColumnDrpChkValues { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
