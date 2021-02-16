//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatisticsOnStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatisticsOnStudent()
        {
            this.WordErrors = new HashSet<WordError>();
        }
    
        public int GameForStudentCode { get; set; }
        public int WeekCode { get; set; }
        public int StudentCode { get; set; }
        public int GameCode { get; set; }
        public System.TimeSpan Time { get; set; }
        public Nullable<int> Errors { get; set; }
        public Nullable<int> ErrorsForWord { get; set; }
        public Nullable<int> NumOfSuccesses { get; set; }
        public Nullable<int> NumOfCorrections { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WordError> WordErrors { get; set; }
        public virtual Week Week { get; set; }
    }
}
