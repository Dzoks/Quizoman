namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.round")]
    public partial class round
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public round()
        {
            round_question = new HashSet<round_question>();
            team_round = new HashSet<team_round>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime date { get; set; }

        public int season_id { get; set; }

        public sbyte deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<round_question> round_question { get; set; }

        public virtual season season { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team_round> team_round { get; set; }
    }
}
