namespace FitnessCenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public string gender { get; set; }
        public System.DateTime birthdate { get; set; }
        public string phone { get; set; }
        public System.DateTime hiredate { get; set; }
        public string passportseries { get; set; }
        public string passportno { get; set; }
        public string skill { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
