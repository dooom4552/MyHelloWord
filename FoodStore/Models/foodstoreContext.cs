using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodStore.Models
{
    public partial class foodstoreContext : DbContext
    {
        public foodstoreContext()
        {
        }

        public foodstoreContext(DbContextOptions<foodstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agency> Agency { get; set; }
        public virtual DbSet<CommissionSurveys> CommissionSurveys { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<EquipSection> EquipSection { get; set; }
        public virtual DbSet<EquipSubsection> EquipSubsection { get; set; }
        public virtual DbSet<EventSections> EventSections { get; set; }
        public virtual DbSet<EventSubsection> EventSubsection { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<EventWork> EventWork { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Pleace1Videocam> Pleace1Videocam { get; set; }
        public virtual DbSet<Pleace2Videocam> Pleace2Videocam { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<RequestEquip> RequestEquip { get; set; }
        public virtual DbSet<SaType> SaType { get; set; }
        public virtual DbSet<Tso> Tso { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Videocams> Videocams { get; set; }
        public virtual DbSet<Yearp> Yearp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=10.16.0.25;port=47585;database=foodstore;uid=root;pwd=itso", x => x.ServerVersion("5.5.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>(entity =>
            {
                entity.ToTable("agency");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgencyMain)
                    .IsRequired()
                    .HasColumnName("agency_main")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Comiss)
                    .HasColumnName("comiss")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Insp)
                    .HasColumnName("insp")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(4)");

                entity.Property(e => e.YearP)
                    .HasColumnName("year_p")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<CommissionSurveys>(entity =>
            {
                entity.ToTable("commission_surveys");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.DateConf)
                    .HasColumnName("date_conf")
                    .HasColumnType("date");

                entity.Property(e => e.DateInv)
                    .HasColumnName("date_inv")
                    .HasColumnType("date");

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Donedate)
                    .HasColumnName("donedate")
                    .HasColumnType("date");

                entity.Property(e => e.NeedPhoto)
                    .HasColumnName("need_photo")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.NeedReport)
                    .HasColumnName("need_report")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.NeedVideo)
                    .HasColumnName("need_video")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Resp)
                    .HasColumnName("resp")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Season)
                    .HasColumnName("season")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Term)
                    .HasColumnName("term")
                    .HasColumnType("date");

                entity.Property(e => e.Test)
                    .HasColumnName("test")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.WhoComp)
                    .HasColumnName("who_comp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.WhoConf)
                    .HasColumnName("who_conf")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.WhoInv)
                    .HasColumnName("who_inv")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(4)");
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.ToTable("config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolderFtp)
                    .HasColumnName("folder_ftp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpFtp)
                    .HasColumnName("ip_ftp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogFtp)
                    .HasColumnName("log_ftp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NewVers)
                    .HasColumnName("new_vers")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NewVersNote)
                    .HasColumnName("new_vers_note")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PassFtp)
                    .HasColumnName("pass_ftp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortFtp)
                    .HasColumnName("port_ftp")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<EquipSection>(entity =>
            {
                entity.ToTable("equip_section");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionEq)
                    .IsRequired()
                    .HasColumnName("section_eq")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<EquipSubsection>(entity =>
            {
                entity.ToTable("equip_subsection");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Subsection)
                    .IsRequired()
                    .HasColumnName("subsection")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<EventSections>(entity =>
            {
                entity.ToTable("event_sections");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SectionEvent)
                    .IsRequired()
                    .HasColumnName("section_event")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EventSubsection>(entity =>
            {
                entity.ToTable("event_subsection");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subsection)
                    .IsRequired()
                    .HasColumnName("subsection")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.ToTable("event_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventType1)
                    .HasColumnName("event_type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(4)");

                entity.Property(e => e.SubsectionEv)
                    .HasColumnName("subsection_ev")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EventWork>(entity =>
            {
                entity.ToTable("event_work");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EvSection)
                    .HasColumnName("ev_section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventW)
                    .HasColumnName("event_w")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(4)");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BMoney).HasColumnName("b_money");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Eventscol)
                    .HasColumnName("eventscol")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExbMoney).HasColumnName("exb_money");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubSection)
                    .HasColumnName("sub_section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Test)
                    .HasColumnName("test")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WhoConf)
                    .HasColumnName("who_conf")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WhoInv)
                    .HasColumnName("who_inv")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Work)
                    .HasColumnName("work")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YearP)
                    .HasColumnName("year_p")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("food");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Pleace1Videocam>(entity =>
            {
                entity.ToTable("pleace1_videocam");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PleaceMain)
                    .IsRequired()
                    .HasColumnName("pleace_main")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Pleace2Videocam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pleace2_videocam");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pleace1)
                    .HasColumnName("pleace1")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pleace2)
                    .IsRequired()
                    .HasColumnName("pleace2")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position1)
                    .HasColumnName("position")
                    .HasColumnType("int(3)");

                entity.Property(e => e.PositionMain)
                    .IsRequired()
                    .HasColumnName("position_main")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<RequestEquip>(entity =>
            {
                entity.ToTable("request_equip");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.DateIns).HasColumnName("date_ins");

                entity.Property(e => e.Force)
                    .HasColumnName("force")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("mediumtext")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Subsection)
                    .HasColumnName("subsection")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Who)
                    .HasColumnName("who")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<SaType>(entity =>
            {
                entity.ToTable("sa_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Tso>(entity =>
            {
                entity.ToTable("tso");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Commissioning)
                    .HasColumnName("commissioning")
                    .HasColumnType("date");

                entity.Property(e => e.Cond)
                    .IsRequired()
                    .HasColumnName("cond")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.ExtraLife)
                    .HasColumnName("extra_life")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Fixed)
                    .HasColumnName("fixed")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Performance)
                    .IsRequired()
                    .HasColumnName("performance")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.RatedLife)
                    .HasColumnName("rated_life")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Who)
                    .HasColumnName("who")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Yoi)
                    .HasColumnName("yoi")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Idusers)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.Property(e => e.Idusers)
                    .HasColumnName("idusers")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Commis)
                    .HasColumnName("commis")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Confurmed)
                    .IsRequired()
                    .HasColumnName("confurmed")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Inv)
                    .HasColumnName("inv")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Merop)
                    .HasColumnName("merop")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Yearpl)
                    .HasColumnName("yearpl")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Zap)
                    .HasColumnName("zap")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");
            });

            modelBuilder.Entity<Videocams>(entity =>
            {
                entity.ToTable("videocams");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Appies)
                    .IsRequired()
                    .HasColumnName("appies")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Commissioning)
                    .HasColumnName("commissioning")
                    .HasColumnType("date");

                entity.Property(e => e.Cond)
                    .IsRequired()
                    .HasColumnName("cond")
                    .HasColumnType("varchar(21)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.ExtraLife)
                    .HasColumnName("extra_life")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Fixed)
                    .HasColumnName("fixed")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Iss)
                    .IsRequired()
                    .HasColumnName("iss")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Performance)
                    .IsRequired()
                    .HasColumnName("performance")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Place1)
                    .HasColumnName("place1")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Place2)
                    .HasColumnName("place2")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RatedLife)
                    .HasColumnName("rated_life")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Turn)
                    .IsRequired()
                    .HasColumnName("turn")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Who)
                    .HasColumnName("who")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("cp1251")
                    .HasCollation("cp1251_general_ci");

                entity.Property(e => e.Yoi)
                    .HasColumnName("yoi")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Yearp>(entity =>
            {
                entity.ToTable("yearp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agency)
                    .HasColumnName("agency")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bsr).HasColumnName("BSr");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Donedate)
                    .HasColumnName("donedate")
                    .HasColumnType("date");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObVsego).HasColumnType("int(11)");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subsection)
                    .HasColumnName("subsection")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Test)
                    .HasColumnName("test")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vbsr).HasColumnName("VBSr");

                entity.Property(e => e.Vip).HasColumnType("int(11)");

                entity.Property(e => e.VipNow).HasColumnType("int(11)");

                entity.Property(e => e.WhoComp)
                    .HasColumnName("who_comp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WhoConf)
                    .HasColumnName("who_conf")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WhoInv)
                    .HasColumnName("who_inv")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Work)
                    .HasColumnName("work")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(4)");

                entity.Property(e => e._1kv)
                    .HasColumnName("1kv")
                    .HasColumnType("int(11)");

                entity.Property(e => e._2kv)
                    .HasColumnName("2kv")
                    .HasColumnType("int(11)");

                entity.Property(e => e._3kv)
                    .HasColumnName("3kv")
                    .HasColumnType("int(11)");

                entity.Property(e => e._4kv)
                    .HasColumnName("4kv")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
