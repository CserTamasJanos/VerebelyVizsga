//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboCop5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Szemelyek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Szemelyek()
        {
            this.Lopasok = new HashSet<Lopasok>();
        }
    
        public int SZID { get; set; }
        public bool SZBEJ { get; set; }
        public bool SZELK { get; set; }
        public string SZNEV { get; set; }
        public Nullable<int> SZSZULHELY { get; set; }
        public Nullable<System.DateTime> SZSZULIDO { get; set; }
        public string SZAN { get; set; }
        public Nullable<int> SZIRSZ { get; set; }
        public Nullable<int> SZVAROS { get; set; }
        public string SZKOZNEV { get; set; }
        public Nullable<int> SZKOZTIP { get; set; }
        public Nullable<int> SZHSZ { get; set; }
        public Nullable<int> SZTELEFON { get; set; }
        public string SZSZIG { get; set; }
    
        public virtual KozteruletTipusok KozteruletTipusok { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lopasok> Lopasok { get; set; }
        public virtual Varosok Varosok { get; set; }
        public virtual Varosok Varosok1 { get; set; }
    }
}
