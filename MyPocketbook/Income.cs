//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPocketbook
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Category { get; set; }
        public string Descrption { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
