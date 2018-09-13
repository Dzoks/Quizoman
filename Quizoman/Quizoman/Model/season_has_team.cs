namespace Quizoman.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.season_has_team")]
    public partial class season_has_team
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int season_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int team_id { get; set; }

        public double total { get; set; }

        public int place { get; set; }

        public sbyte deleted { get; set; }

        public virtual season season { get; set; }

        public virtual team team { get; set; }
    }
}
