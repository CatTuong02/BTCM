//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieManagementApplication.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public actor()
        {
            this.movie_cast = new HashSet<movie_cast>();
        }
    
        public int act_id { get; set; }
        public string act_fname { get; set; }
        public string act_lname { get; set; }
        public string act_gender { get; set; }
        public string act_image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movie_cast> movie_cast { get; set; }
    }
}
