namespace Quizoman.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.round_question")]
    public partial class round_question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public round_question()
        {
            team_answer = new HashSet<team_answer>();
        }

        public int id { get; set; }

        public int question_number { get; set; }

        public int round_id { get; set; }

        public int question_id { get; set; }

        public sbyte deleted { get; set; }

        public virtual question question { get; set; }

        public virtual round round { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team_answer> team_answer { get; set; }
    }
}
