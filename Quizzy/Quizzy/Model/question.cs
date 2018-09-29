namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.question")]
    public partial class question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public question()
        {
            round_question = new HashSet<round_question>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string question_text { get; set; }

        [Required]
        [StringLength(255)]
        public string answer { get; set; }

        [StringLength(255)]
        public string youtube_link { get; set; }

        public sbyte deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<round_question> round_question { get; set; }

        public override string ToString()
        {
            return question_text;
        }

        public bool CheckValidity()
        {
            return question_text?.Length > 0 && answer?.Length > 0 && ValidYoutubeLink();
        }

        private bool ValidYoutubeLink()
        {
            if (String.IsNullOrEmpty(youtube_link))
                return true;
            return Utility.IsYoutubeLinkValid(youtube_link);

        }
    }
}
