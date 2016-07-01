namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MaintinfoCodeFirst")
        {
        }

        public virtual DbSet<CENTRE_INFORMATIQUE> CENTRE_INFORMATIQUE { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<CONTRAT> CONTRAT { get; set; }
        public virtual DbSet<EQUIPEMENT> EQUIPEMENT { get; set; }
        public virtual DbSet<MODELE> MODELE { get; set; }
        public virtual DbSet<SECTEUR> SECTEUR { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TARIF> TARIF { get; set; }
        public virtual DbSet<TYPE_EQUIPEMENT> TYPE_EQUIPEMENT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CENTRE_INFORMATIQUE>()
                .Property(e => e.ADRESSECENTRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CENTRE_INFORMATIQUE>()
                .Property(e => e.VILLECENTRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CENTRE_INFORMATIQUE>()
                .Property(e => e.TELCENTRE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CENTRE_INFORMATIQUE>()
                .HasMany(e => e.CONTRAT)
                .WithRequired(e => e.CENTRE_INFORMATIQUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CENTRE_INFORMATIQUE>()
                .HasMany(e => e.EQUIPEMENT)
                .WithRequired(e => e.CENTRE_INFORMATIQUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.NOMCLIENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ADRESSECLIENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.VILLECLIENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.CODEPOSTAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.TELCLIENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.CENTRE_INFORMATIQUE)
                .WithRequired(e => e.CLIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.CONTRAT)
                .WithRequired(e => e.CLIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRAT>()
                .Property(e => e.MONTANTCONTRAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CONTRAT>()
                .Property(e => e.COMMENTAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<MODELE>()
                .Property(e => e.LIBELLEMODELE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MODELE>()
                .HasMany(e => e.EQUIPEMENT)
                .WithRequired(e => e.MODELE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECTEUR>()
                .Property(e => e.LIBELLESECTEUR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SECTEUR>()
                .HasMany(e => e.CENTRE_INFORMATIQUE)
                .WithRequired(e => e.SECTEUR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TARIF>()
                .Property(e => e.TARIFMODELE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TARIF>()
                .HasMany(e => e.MODELE)
                .WithRequired(e => e.TARIF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.LIBELLETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .HasMany(e => e.MODELE)
                .WithRequired(e => e.TYPE_EQUIPEMENT)
                .WillCascadeOnDelete(false);
        }
    }
}
