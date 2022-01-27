namespace FitnessCenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int id { get; set; }
        public Nullable<int> trainer_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public System.DateTime startdate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
