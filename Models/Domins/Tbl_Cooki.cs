//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Storenarm2.Models.Domins
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Cooki
    {
        public int id { get; set; }
        public int userid { get; set; }
        public string cooki { get; set; }
    
        public virtual Tbl_User Tbl_User { get; set; }
    }
}
