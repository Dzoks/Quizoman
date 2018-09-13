namespace Quizoman.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuizomanDB : DbContext
    {
        private static string defaultConnectionString = $"Server={Properties.Settings.Default.Server};Database={Properties.Settings.Default.Database};Uid={Properties.Settings.Default.User};Pwd={Properties.Settings.Default.Password};CharSet = utf8; ";

        public QuizomanDB(string connectionString) :
            base(connectionString)
        {
        }
        public QuizomanDB() :
            base(defaultConnectionString)
        {
        }

        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<round> rounds { get; set; }
        public virtual DbSet<round_question> round_question { get; set; }
        public virtual DbSet<season> seasons { get; set; }
        public virtual DbSet<season_has_team> season_has_team { get; set; }
        public virtual DbSet<team> teams { get; set; }
        public virtual DbSet<team_answer> team_answer { get; set; }
        public virtual DbSet<team_round> team_round { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<question>()
                .Property(e => e.question_text)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.youtube_link)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .HasMany(e => e.round_question)
                .WithRequired(e => e.question)
                .HasForeignKey(e => e.question_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<round>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<round>()
                .HasMany(e => e.round_question)
                .WithRequired(e => e.round)
                .HasForeignKey(e => e.round_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<round>()
                .HasMany(e => e.team_round)
                .WithRequired(e => e.round)
                .HasForeignKey(e => e.round_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<round_question>()
                .HasMany(e => e.team_answer)
                .WithRequired(e => e.round_question)
                .HasForeignKey(e => e.round_question_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<season>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<season>()
                .HasMany(e => e.rounds)
                .WithRequired(e => e.season)
                .HasForeignKey(e => e.season_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<season>()
                .HasMany(e => e.season_has_team)
                .WithRequired(e => e.season)
                .HasForeignKey(e => e.season_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<team>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .HasMany(e => e.season_has_team)
                .WithRequired(e => e.team)
                .HasForeignKey(e => e.team_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<team>()
                .HasMany(e => e.team_round)
                .WithRequired(e => e.team)
                .HasForeignKey(e => e.team_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<team_round>()
                .HasMany(e => e.team_answer)
                .WithRequired(e => e.team_round)
                .HasForeignKey(e => new { e.team_round_team_id, e.team_round_round_id })
                .WillCascadeOnDelete(false);
        }
    }
}
