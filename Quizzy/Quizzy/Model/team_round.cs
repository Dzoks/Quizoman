namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.team_round")]
    public partial class team_round
    {
        public int id { get; set; }

        public int team_id { get; set; }

        
        public int round_id { get; set; }

        public double total { get; set; }
        
        public sbyte deleted { get; set; }

        public virtual round round { get; set; }

        public virtual team team { get; set; }
    }
}
