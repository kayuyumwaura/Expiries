//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expiries.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_doctors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_doctors()
        {
            this.tb_patient_expiries = new HashSet<tb_patient_expiries>();
        }
    
        public short doc_id { get; set; }
        public string doc_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_patient_expiries> tb_patient_expiries { get; set; }
    }
}
