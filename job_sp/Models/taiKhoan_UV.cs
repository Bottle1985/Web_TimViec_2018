//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace job_sp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class taiKhoan_UV
    {
        public string ID { get; set; }
        public string ten_UV { get; set; }
        public string matKhau { get; set; }
    
        public virtual tt_ungVien tt_ungVien { get; set; }
    }
}
