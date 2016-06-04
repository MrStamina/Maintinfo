/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2008                     */
/* Date de création :  01/06/2016 10:45:01                      */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CENTRE_INFORMATIQUE') and o.name = 'FK_CENTRE_I_POSSEDER_CLIENT')
alter table CENTRE_INFORMATIQUE
   drop constraint FK_CENTRE_I_POSSEDER_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CENTRE_INFORMATIQUE') and o.name = 'FK_CENTRE_I_SITUER_SECTEUR')
alter table CENTRE_INFORMATIQUE
   drop constraint FK_CENTRE_I_SITUER_SECTEUR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTRAT') and o.name = 'FK_CONTRAT_CONCERNER_CENTRE_I')
alter table CONTRAT
   drop constraint FK_CONTRAT_CONCERNER_CENTRE_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTRAT') and o.name = 'FK_CONTRAT_SIGNER_CLIENT')
alter table CONTRAT
   drop constraint FK_CONTRAT_SIGNER_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EQUIPEMENT') and o.name = 'FK_EQUIPEME_ASSOCIER_MODELE')
alter table EQUIPEMENT
   drop constraint FK_EQUIPEME_ASSOCIER_MODELE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EQUIPEMENT') and o.name = 'FK_EQUIPEME_CONFIGURE_CENTRE_I')
alter table EQUIPEMENT
   drop constraint FK_EQUIPEME_CONFIGURE_CENTRE_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EQUIPEMENT') and o.name = 'FK_EQUIPEME_EST_PRESE_CONTRAT')
alter table EQUIPEMENT
   drop constraint FK_EQUIPEME_EST_PRESE_CONTRAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODELE') and o.name = 'FK_MODELE_APPARTENI_TYPE_EQU')
alter table MODELE
   drop constraint FK_MODELE_APPARTENI_TYPE_EQU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODELE') and o.name = 'FK_MODELE_CORRESPON_TARIF')
alter table MODELE
   drop constraint FK_MODELE_CORRESPON_TARIF
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CENTRE_INFORMATIQUE')
            and   name  = 'POSSEDER_FK'
            and   indid > 0
            and   indid < 255)
   drop index CENTRE_INFORMATIQUE.POSSEDER_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CENTRE_INFORMATIQUE')
            and   name  = 'SITUER_FK'
            and   indid > 0
            and   indid < 255)
   drop index CENTRE_INFORMATIQUE.SITUER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CENTRE_INFORMATIQUE')
            and   type = 'U')
   drop table CENTRE_INFORMATIQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTRAT')
            and   name  = 'CONCERNER_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTRAT.CONCERNER_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTRAT')
            and   name  = 'SIGNER_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTRAT.SIGNER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONTRAT')
            and   type = 'U')
   drop table CONTRAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EQUIPEMENT')
            and   name  = 'EST_PRESENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index EQUIPEMENT.EST_PRESENT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EQUIPEMENT')
            and   name  = 'CONFIGURER_FK'
            and   indid > 0
            and   indid < 255)
   drop index EQUIPEMENT.CONFIGURER_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EQUIPEMENT')
            and   name  = 'ASSOCIER_FK'
            and   indid > 0
            and   indid < 255)
   drop index EQUIPEMENT.ASSOCIER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EQUIPEMENT')
            and   type = 'U')
   drop table EQUIPEMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODELE')
            and   name  = 'CORRESPONDRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODELE.CORRESPONDRE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODELE')
            and   name  = 'APPARTENIR_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODELE.APPARTENIR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODELE')
            and   type = 'U')
   drop table MODELE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SECTEUR')
            and   type = 'U')
   drop table SECTEUR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARIF')
            and   type = 'U')
   drop table TARIF
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_EQUIPEMENT')
            and   type = 'U')
   drop table TYPE_EQUIPEMENT
go

/*==============================================================*/
/* Table : CENTRE_INFORMATIQUE                                  */
/*==============================================================*/
create table CENTRE_INFORMATIQUE (
   NUMEROCENTRE         int                  identity,
   IDSECTEUR            int                  not null,
   NUMCLIENT            int                  not null,
   ADRESSECENTRE        char(100)            not null,
   VILLECENTRE          char(40)             not null,
   TELCENTRE            char(12)             not null,
   constraint PK_CENTRE_INFORMATIQUE primary key nonclustered (NUMEROCENTRE)
)
go

/*==============================================================*/
/* Index : SITUER_FK                                            */
/*==============================================================*/
create index SITUER_FK on CENTRE_INFORMATIQUE (
IDSECTEUR ASC
)
go

/*==============================================================*/
/* Index : POSSEDER_FK                                          */
/*==============================================================*/
create index POSSEDER_FK on CENTRE_INFORMATIQUE (
NUMCLIENT ASC
)
go

/*==============================================================*/
/* Table : CLIENT                                               */
/*==============================================================*/
create table CLIENT (
   NUMCLIENT            int                  identity,
   NOMCLIENT            char(40)             not null,
   ADRESSECLIENT        char(100)            not null,
   VILLECLIENT          char(40)             not null,
   CODEPOSTAL           char(5)              not null,
   TELCLIENT            char(12)             not null,
   constraint PK_CLIENT primary key nonclustered (NUMCLIENT)
)
go

/*==============================================================*/
/* Table : CONTRAT                                              */
/*==============================================================*/
create table CONTRAT (
   NUMCONTRAT           int                  identity,
   NUMCLIENT            int                  not null,
   NUMEROCENTRE         int                  not null,
   MONTANTCONTRAT       money                not null,
   DATEDEBUT            datetime			not null,
   DATEECHEANCE			datetime			not null,
   COMMENTAIRE			char(100)			null,
   constraint PK_CONTRAT primary key nonclustered (NUMCONTRAT)
)
go

/*==============================================================*/
/* Index : SIGNER_FK                                            */
/*==============================================================*/
create index SIGNER_FK on CONTRAT (
NUMCLIENT ASC
)
go

/*==============================================================*/
/* Index : CONCERNER_FK                                         */
/*==============================================================*/
create index CONCERNER_FK on CONTRAT (
NUMEROCENTRE ASC
)
go

/*==============================================================*/
/* Table : EQUIPEMENT                                           */
/*==============================================================*/
create table EQUIPEMENT (
   NUMEROSERIE          int                  identity,
   IDMODELE             int                  not null,
   NUMEROCENTRE         int                  not null,
   NUMCONTRAT           int                  null,
   constraint PK_EQUIPEMENT primary key nonclustered (NUMEROSERIE)
)
go

/*==============================================================*/
/* Index : ASSOCIER_FK                                          */
/*==============================================================*/
create index ASSOCIER_FK on EQUIPEMENT (
IDMODELE ASC
)
go

/*==============================================================*/
/* Index : CONFIGURER_FK                                        */
/*==============================================================*/
create index CONFIGURER_FK on EQUIPEMENT (
NUMEROCENTRE ASC
)
go

/*==============================================================*/
/* Index : EST_PRESENT_FK                                       */
/*==============================================================*/
create index EST_PRESENT_FK on EQUIPEMENT (
NUMCONTRAT ASC
)
go

/*==============================================================*/
/* Table : MODELE                                               */
/*==============================================================*/
create table MODELE (
   IDMODELE             int                  identity,
   IDTYPE               int                  not null,
   CODETARIF            int                  not null,
   LIBELLEMODELE        char(40)             not null,
   constraint PK_MODELE primary key nonclustered (IDMODELE)
)
go

/*==============================================================*/
/* Index : APPARTENIR_FK                                        */
/*==============================================================*/
create index APPARTENIR_FK on MODELE (
IDTYPE ASC
)
go

/*==============================================================*/
/* Index : CORRESPONDRE_FK                                      */
/*==============================================================*/
create index CORRESPONDRE_FK on MODELE (
CODETARIF ASC
)
go

/*==============================================================*/
/* Table : SECTEUR                                              */
/*==============================================================*/
create table SECTEUR (
   IDSECTEUR            int                  identity,
   LIBELLESECTEUR       char(40)             not null,
   constraint PK_SECTEUR primary key nonclustered (IDSECTEUR)
)
go

/*==============================================================*/
/* Table : TARIF                                                */
/*==============================================================*/
create table TARIF (
   CODETARIF            int                  not null,
   DATETARIF            datetime             not null,
   TARIFMODELE          money                not null,
   constraint PK_TARIF primary key nonclustered (CODETARIF)
)
go

/*==============================================================*/
/* Table : TYPE_EQUIPEMENT                                      */
/*==============================================================*/
create table TYPE_EQUIPEMENT (
   IDTYPE               int                  identity,
   LIBELLETYPE          varchar(30)          not null,
   constraint PK_TYPE_EQUIPEMENT primary key nonclustered (IDTYPE)
)
go

alter table CENTRE_INFORMATIQUE
   add constraint FK_CENTRE_I_POSSEDER_CLIENT foreign key (NUMCLIENT)
      references CLIENT (NUMCLIENT)
go

alter table CENTRE_INFORMATIQUE
   add constraint FK_CENTRE_I_SITUER_SECTEUR foreign key (IDSECTEUR)
      references SECTEUR (IDSECTEUR)
go

alter table CONTRAT
   add constraint FK_CONTRAT_CONCERNER_CENTRE_I foreign key (NUMEROCENTRE)
      references CENTRE_INFORMATIQUE (NUMEROCENTRE)
go

alter table CONTRAT
   add constraint FK_CONTRAT_SIGNER_CLIENT foreign key (NUMCLIENT)
      references CLIENT (NUMCLIENT)
go

alter table EQUIPEMENT
   add constraint FK_EQUIPEME_ASSOCIER_MODELE foreign key (IDMODELE)
      references MODELE (IDMODELE)
go

alter table EQUIPEMENT
   add constraint FK_EQUIPEME_CONFIGURE_CENTRE_I foreign key (NUMEROCENTRE)
      references CENTRE_INFORMATIQUE (NUMEROCENTRE)
go

alter table EQUIPEMENT
   add constraint FK_EQUIPEME_EST_PRESE_CONTRAT foreign key (NUMCONTRAT)
      references CONTRAT (NUMCONTRAT)
go

alter table MODELE
   add constraint FK_MODELE_APPARTENI_TYPE_EQU foreign key (IDTYPE)
      references TYPE_EQUIPEMENT (IDTYPE)
go

alter table MODELE
   add constraint FK_MODELE_CORRESPON_TARIF foreign key (CODETARIF)
      references TARIF (CODETARIF)
go

