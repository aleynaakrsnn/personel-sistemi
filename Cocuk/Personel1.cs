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
    
    public partial class Personel1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel1()
        {
            this.Cocuks = new HashSet<Cocuk>();
        }
    
        public int PersonelNo { get; set; }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> BaslamaTarihi { get; set; }
        public string VardiyaDurumu { get; set; }
        public Nullable<decimal> Maas { get; set; }
        public Nullable<int> Prim { get; set; }
        public Nullable<int> GorevNo { get; set; }
        public Nullable<int> UnvanNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cocuk> Cocuks { get; set; }
        public virtual Gorev Gorev { get; set; }
        public virtual Unvanlar Unvanlar { get; set; }
    }
}