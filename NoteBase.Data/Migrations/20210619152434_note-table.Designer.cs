// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteBase.Data;

namespace NoteBase.Data.Migrations
{
    [DbContext(typeof(NoteBaseIdentityContext))]
    [Migration("20210619152434_note-table")]
    partial class notetable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NoteBase.Core.Models.NoteBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("TopId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NoteBooks");
                });

            modelBuilder.Entity("NoteBase.Core.Models.NoteTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoteId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NoteId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTags");
                });

            modelBuilder.Entity("NoteBase.Core.Models.Notes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NoteBookId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NoteBookId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("NoteBase.Core.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NoteBase.Core.Models.UserApp", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserApp");
                });

            modelBuilder.Entity("NoteBase.Core.Models.UserRefreshToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("NoteBase.Core.Models.NoteBooks", b =>
                {
                    b.HasOne("NoteBase.Core.Models.UserApp", "UserApp")
                        .WithMany("NoteBooks")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_userapp_notebooks");

                    b.Navigation("UserApp");
                });

            modelBuilder.Entity("NoteBase.Core.Models.NoteTags", b =>
                {
                    b.HasOne("NoteBase.Core.Models.Notes", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteId")
                        .HasConstraintName("FK_notes_notetags")
                        .IsRequired();

                    b.HasOne("NoteBase.Core.Models.Tags", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_tags_notetags")
                        .IsRequired();

                    b.Navigation("Note");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("NoteBase.Core.Models.Notes", b =>
                {
                    b.HasOne("NoteBase.Core.Models.NoteBooks", "NoteBook")
                        .WithMany("Notes")
                        .HasForeignKey("NoteBookId")
                        .HasConstraintName("FK_notebooks_notes")
                        .IsRequired();

                    b.Navigation("NoteBook");
                });

            modelBuilder.Entity("NoteBase.Core.Models.NoteBooks", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("NoteBase.Core.Models.Notes", b =>
                {
                    b.Navigation("NoteTags");
                });

            modelBuilder.Entity("NoteBase.Core.Models.Tags", b =>
                {
                    b.Navigation("NoteTags");
                });

            modelBuilder.Entity("NoteBase.Core.Models.UserApp", b =>
                {
                    b.Navigation("NoteBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
