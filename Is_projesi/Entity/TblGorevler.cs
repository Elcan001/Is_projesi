//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Is_projesi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblGorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGorevler()
        {
            this.TblGorevDetaylar = new HashSet<TblGorevDetaylar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IsitehvilVeren { get; set; }
        public Nullable<int> IsitehvilAlan { get; set; }
        public string Veziyyet { get; set; }
        public string Durum { get; set; }
        public Nullable<System.DateTime> Tarix { get; set; }
    
        public virtual TblPersonel C_TblPersonel { get; set; }
        public virtual TblPersonel C_TblPersonel1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblGorevDetaylar> TblGorevDetaylar { get; set; }
    }
}