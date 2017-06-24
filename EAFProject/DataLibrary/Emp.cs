//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLibrary
{
    using System;
    using System.Collections.Generic;

    public partial class Emp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp()
        {
            this.Emp1 = new HashSet<Emp>();
            this.InterviewComments = new HashSet<InterviewComment>();
            this.Interviews = new HashSet<Interview>();
            this.RequestComments = new HashSet<RequestComment>();
        }

        public string SWG { get; set; }
        public string Name { get; set; }
        public int JobId { get; set; }
        public int DeptId { get; set; }
        public int ProductId { get; set; }
        public string ManagerId { get; set; }
        public System.DateTime DOJ { get; set; }
        public string Email { get; set; }
        public DateTime? DOR { get; set; }
        public DateTime? DOL { get; set; }
        public DateTime? DOO { get; set; }

        public virtual Dept Dept { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp> Emp1 { get; set; }
        public virtual Emp Emp2 { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterviewComment> InterviewComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interview> Interviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestComment> RequestComments { get; set; }
    }
}
