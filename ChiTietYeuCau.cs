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
    
    public partial class ChiTietYeuCau
    {
        public int MaYC { get; set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
    
        public virtual YeuCauMuon YeuCauMuon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
