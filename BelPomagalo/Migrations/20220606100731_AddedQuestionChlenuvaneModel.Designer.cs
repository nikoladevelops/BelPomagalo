﻿// <auto-generated />
using BelPomagalo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BelPomagalo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220606100731_AddedQuestionChlenuvaneModel")]
    partial class AddedQuestionChlenuvaneModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("BelPomagalo.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BornDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BornLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BelPomagalo.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("BelPomagalo.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BelPomagalo.Models.GrammarRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GrammarRules");
                });

            modelBuilder.Entity("BelPomagalo.Models.LexicalRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LexicalRules");
                });

            modelBuilder.Entity("BelPomagalo.Models.Opposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Oppositions");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompositionDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdeologicalSuggestions")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotivesAndFigures")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PublishedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("PublishedWorks");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishedWorkId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("PublishedWorkId");

                    b.ToTable("PublishedWorkCharacters");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishedWorkId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("PublishedWorkId");

                    b.ToTable("PublishedWorkGenres");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkOpposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OppositionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishedWorkId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OppositionId");

                    b.HasIndex("PublishedWorkId");

                    b.ToTable("PublishedWorkOppositions");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkTheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishedWorkId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThemeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PublishedWorkId");

                    b.HasIndex("ThemeId");

                    b.ToTable("PublishedWorkThemes");
                });

            modelBuilder.Entity("BelPomagalo.Models.PunctuationRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PunctuationRules");
                });

            modelBuilder.Entity("BelPomagalo.Models.QuestionChlenuvane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CorrectAnswers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrectSentence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CountAnswers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sentence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WrongAnswers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QuestionsChlenuvane");
                });

            modelBuilder.Entity("BelPomagalo.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("BelPomagalo.Models.Character", b =>
                {
                    b.HasOne("BelPomagalo.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWork", b =>
                {
                    b.HasOne("BelPomagalo.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkCharacter", b =>
                {
                    b.HasOne("BelPomagalo.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BelPomagalo.Models.PublishedWork", "PublishedWork")
                        .WithMany()
                        .HasForeignKey("PublishedWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("PublishedWork");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkGenre", b =>
                {
                    b.HasOne("BelPomagalo.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BelPomagalo.Models.PublishedWork", "PublishedWork")
                        .WithMany()
                        .HasForeignKey("PublishedWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("PublishedWork");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkOpposition", b =>
                {
                    b.HasOne("BelPomagalo.Models.Opposition", "Opposition")
                        .WithMany()
                        .HasForeignKey("OppositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BelPomagalo.Models.PublishedWork", "PublishedWork")
                        .WithMany()
                        .HasForeignKey("PublishedWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opposition");

                    b.Navigation("PublishedWork");
                });

            modelBuilder.Entity("BelPomagalo.Models.PublishedWorkTheme", b =>
                {
                    b.HasOne("BelPomagalo.Models.PublishedWork", "PublishedWork")
                        .WithMany()
                        .HasForeignKey("PublishedWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BelPomagalo.Models.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublishedWork");

                    b.Navigation("Theme");
                });
#pragma warning restore 612, 618
        }
    }
}