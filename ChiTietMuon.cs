//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLITHUVIENWINFORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietMuon
    {
        public int MaMuon { get; set; }
        public int SachMaSach { get; set; }
        public int DaTra { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public System.DateTime NgayHetHan { get; set; }
    
        public virtual Muon Muon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
