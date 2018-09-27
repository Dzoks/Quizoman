namespace Quizzy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quizoman_db.team")]
    public partial class team : IEquatable<team>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public team()
        {
            season_has_team = new HashSet<season_has_team>();
            team_round = new HashSet<team_round>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public sbyte deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<season_has_team> season_has_team { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team_round> team_round { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as team);
        }

        public bool Equals(team other)
        {
            return other != null &&
                   id == other.id;
        }

        public override string ToString()
        {
            return name;
        }

        public static bool operator ==(team team1, team team2)
        {
            return EqualityComparer<team>.Default.Equals(team1, team2);
        }

        public static bool operator !=(team team1, team team2)
        {
            return !(team1 == team2);
        }
    }
}
