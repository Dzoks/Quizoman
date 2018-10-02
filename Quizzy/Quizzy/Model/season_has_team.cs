namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.season_has_team")]
    public partial class season_has_team
    {

        public int id { get; set; }

        public int season_id { get; set; }

        public int team_id { get; set; }

        public double total { get; set; }
        public sbyte deleted { get; set; }

        public virtual season season { get; set; }

        public virtual team team { get; set; }
    }
}
