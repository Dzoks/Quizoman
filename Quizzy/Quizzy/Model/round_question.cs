namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.round_question")]
    public partial class round_question
    {
        public int id { get; set; }

        public int question_number { get; set; }

        public int round_id { get; set; }

        public int question_id { get; set; }

        public sbyte deleted { get; set; }

        public virtual question question { get; set; }

        public virtual round round { get; set; }

      
    }
}
