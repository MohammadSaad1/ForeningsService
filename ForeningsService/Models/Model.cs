namespace ForeningsService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model2")
        {
            this.Configuration.ProxyCreationEnabled = false;

        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Aktivitet> Aktivitet { get; set; }
        public virtual DbSet<Aktivitetdeltager> Aktivitetdeltager { get; set; }
        public virtual DbSet<Aktivitetsart> Aktivitetsart { get; set; }
        public virtual DbSet<Aktivitetstype> Aktivitetstype { get; set; }
        public virtual DbSet<Ansat> Ansat { get; set; }
        public virtual DbSet<Beboer> Beboer { get; set; }
        public virtual DbSet<Besked> Besked { get; set; }
        public virtual DbSet<Bolig> Bolig { get; set; }
        public virtual DbSet<Forening> Forening { get; set; }
        public virtual DbSet<Kontrakt> Kontrakt { get; set; }
        public virtual DbSet<Kreditorliste> Kreditorliste { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Opfølgning> Opfølgning { get; set; }
        public virtual DbSet<Opgaver> Opgaver { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PostnrBy> PostnrBy { get; set; }
        public virtual DbSet<Referat> Referat { get; set; }
        public virtual DbSet<Rettigheder> Rettigheder { get; set; }
        public virtual DbSet<Samarbejdsfirma> Samarbejdsfirma { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Underaktivitet> Underaktivitet { get; set; }
        public virtual DbSet<Underaktivitetstype> Underaktivitetstype { get; set; }
        public virtual DbSet<ZMedlem> ZMedlem { get; set; }
        public virtual DbSet<ZMøde> ZMøde { get; set; }
        public virtual DbSet<ZReferatgodkendelse> ZReferatgodkendelse { get; set; }
        public virtual DbSet<YCSVBoende> YCSVBoende { get; set; }
        public virtual DbSet<YCSVKreditor> YCSVKreditor { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>()
                .HasMany(e => e.Bolig1)
                .WithOptional(e => e.Adresse1)
                .HasForeignKey(e => e.AdresseID);

            modelBuilder.Entity<Adresse>()
                .HasMany(e => e.Person1)
                .WithOptional(e => e.Adresse1)
                .HasForeignKey(e => e.AdresseID);

            modelBuilder.Entity<Agenda>()
                .HasMany(e => e.Referat1)
                .WithOptional(e => e.Agenda1)
                .HasForeignKey(e => e.AgendaID);

            modelBuilder.Entity<Ansat>()
                .HasMany(e => e.Person1)
                .WithOptional(e => e.Ansat1)
                .HasForeignKey(e => e.AnsatID);

            modelBuilder.Entity<Bolig>()
                .HasMany(e => e.Adresse)
                .WithOptional(e => e.Bolig)
                .HasForeignKey(e => e.BoligID);

            modelBuilder.Entity<Login>()
                .HasMany(e => e.Person1)
                .WithOptional(e => e.Login1)
                .HasForeignKey(e => e.LoginID);

            modelBuilder.Entity<Opfølgning>()
                .HasMany(e => e.Underaktivitet1)
                .WithOptional(e => e.Opfølgning1)
                .HasForeignKey(e => e.OpfølgningID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Adresse)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Ansat)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Login)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Referat>()
                .HasMany(e => e.Agenda)
                .WithOptional(e => e.Referat)
                .HasForeignKey(e => e.ReferatID);

            modelBuilder.Entity<Underaktivitet>()
                .Property(e => e.MTTS)
                .IsFixedLength();

            modelBuilder.Entity<Underaktivitet>()
                .HasMany(e => e.Opfølgning)
                .WithOptional(e => e.Underaktivitet)
                .HasForeignKey(e => e.UnderaktivitetID);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
