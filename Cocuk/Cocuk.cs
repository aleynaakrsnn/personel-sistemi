//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cocuk
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cocuk
    {
        public int CocukNo { get; set; }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> PersonelNo { get; set; }
    
        public virtual Personel1 Personel1 { get; set; }
    }
}
