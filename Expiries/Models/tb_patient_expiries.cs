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
    
    public partial class tb_patient_expiries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_patient_expiries()
        {
            this.tb_icdcodes = new HashSet<tb_icdcodes>();
        }
    
        public int expiry_id { get; set; }
        public string expiry_serial_number { get; set; }
        public string hospital_death { get; set; }
        public Nullable<System.DateTime> date_of_expiry { get; set; }
        public string file_number { get; set; }
        public string patient_name { get; set; }
        public string Patient_sex { get; set; }
        public Nullable<short> patient_age { get; set; }
        public string patient_age_type { get; set; }
        public Nullable<short> race_id { get; set; }
        public Nullable<short> ward_id { get; set; }
        public string place_of_death_other { get; set; }
        public Nullable<short> doc_id { get; set; }
        public string expiry_comment { get; set; }
        public string status { get; set; }
        public Nullable<short> add_user { get; set; }
        public Nullable<System.DateTime> add_Time { get; set; }
        public Nullable<short> modify_user { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
    
        public virtual tb_doctors tb_doctors { get; set; }
        public virtual tb_users tb_users { get; set; }
        public virtual tb_users tb_users1 { get; set; }
        public virtual tb_race tb_race { get; set; }
        public virtual tb_wards tb_wards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_icdcodes> tb_icdcodes { get; set; }
    }
}
