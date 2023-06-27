﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("Domain.ActorShowRole", b =>
                {
                    b.Property<string>("ActorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Pay")
                        .HasColumnType("REAL");

                    b.HasKey("ActorId", "RoleId", "ShowId");

                    b.HasIndex("RoleId");

                    b.HasIndex("ShowId");

                    b.ToTable("ActorShowRoles");
                });

            modelBuilder.Entity("Domain.ActorShowRoleAudition", b =>
                {
                    b.Property<string>("ActorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuditionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ShowRoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("ActorId", "AuditionId", "ShowRoleId");

                    b.HasIndex("AuditionId");

                    b.HasIndex("ShowRoleId");

                    b.ToTable("ActorShowRoleAuditions");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Audition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoURL")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Auditions");
                });

            modelBuilder.Entity("Domain.AuditionReview", b =>
                {
                    b.Property<Guid>("AuditionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewerId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Review")
                        .HasColumnType("REAL");

                    b.HasKey("AuditionId", "ReviewerId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("AuditionReviews");
                });

            modelBuilder.Entity("Domain.Festival", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OrganizerId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ZipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Festivals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("475c1703-f99a-4cb8-8f4f-f74cc5c15b82"),
                            City = "Beograd",
                            EndDate = new DateTime(2023, 8, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3434),
                            Name = "Festival 1",
                            StartDate = new DateTime(2023, 7, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3428),
                            ZipCode = 36300
                        },
                        new
                        {
                            Id = new Guid("1844b0f9-26df-488f-af46-c4710ab29876"),
                            City = "Beograd",
                            EndDate = new DateTime(2023, 10, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3444),
                            Name = "Festival 2",
                            StartDate = new DateTime(2023, 9, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3444),
                            ZipCode = 36300
                        },
                        new
                        {
                            Id = new Guid("660b182f-75e1-49c9-bc2d-cc460dc4ecb6"),
                            City = "Beograd",
                            EndDate = new DateTime(2023, 12, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3451),
                            Name = "Festival 3",
                            StartDate = new DateTime(2023, 11, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3450),
                            ZipCode = 36300
                        },
                        new
                        {
                            Id = new Guid("98611f2c-914e-4cec-b25f-f55933f40fae"),
                            City = "Beograd",
                            EndDate = new DateTime(2024, 2, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3457),
                            Name = "Festival 4",
                            StartDate = new DateTime(2024, 1, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3456),
                            ZipCode = 36300
                        },
                        new
                        {
                            Id = new Guid("c58672a3-6acf-4252-bd91-cf643ddc82e0"),
                            City = "Beograd",
                            EndDate = new DateTime(2024, 4, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3463),
                            Name = "Festival 5",
                            StartDate = new DateTime(2024, 3, 27, 10, 26, 39, 357, DateTimeKind.Utc).AddTicks(3463),
                            ZipCode = 36300
                        });
                });

            modelBuilder.Entity("Domain.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Domain.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FestivalId")
                        .HasColumnType("TEXT");

                    b.Property<int>("LengthOfPlay")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeOfPlay")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FestivalId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Domain.Show", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StoryWriterName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("Domain.ShowApplicationReview", b =>
                {
                    b.Property<Guid>("ShowId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewerId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Acceptable")
                        .HasColumnType("INTEGER");

                    b.HasKey("ShowId", "ReviewerId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("ShowApplicationReviews");
                });

            modelBuilder.Entity("Domain.ShowRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShowRoles");
                });

            modelBuilder.Entity("Domain.Theatre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManagerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfCreation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId")
                        .IsUnique();

                    b.ToTable("Theatres");
                });

            modelBuilder.Entity("Domain.TheatreShows", b =>
                {
                    b.Property<Guid>("TheatreId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfActors")
                        .HasColumnType("INTEGER");

                    b.HasKey("TheatreId", "ShowId");

                    b.HasIndex("ShowId");

                    b.ToTable("TheatreShows");
                });

            modelBuilder.Entity("Domain.TheatreShowSchedule", b =>
                {
                    b.Property<Guid>("TheatreId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ScheduleId")
                        .HasColumnType("TEXT");

                    b.HasKey("TheatreId", "ShowId", "ScheduleId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("ShowId");

                    b.ToTable("TheaterShowSchedules");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.ActorShowRole", b =>
                {
                    b.HasOne("Domain.AppUser", "Actor")
                        .WithMany("ActingRoles")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ShowRole", "Role")
                        .WithMany("RoleActors")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Show", "Show")
                        .WithMany("Actors")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Role");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Domain.ActorShowRoleAudition", b =>
                {
                    b.HasOne("Domain.AppUser", "Actor")
                        .WithMany("Auditions")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Audition", "Audition")
                        .WithMany("Auditioners")
                        .HasForeignKey("AuditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ShowRole", "ShowRole")
                        .WithMany("ShowRoleAuditions")
                        .HasForeignKey("ShowRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Audition");

                    b.Navigation("ShowRole");
                });

            modelBuilder.Entity("Domain.AuditionReview", b =>
                {
                    b.HasOne("Domain.Audition", "Audition")
                        .WithMany("Reviews")
                        .HasForeignKey("AuditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.AppUser", "Reviewer")
                        .WithMany("AuditionReviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Audition");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("Domain.Festival", b =>
                {
                    b.HasOne("Domain.Theatre", "Organizer")
                        .WithMany("FestivalsOrganized")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("Domain.Photo", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("Domain.Schedule", b =>
                {
                    b.HasOne("Domain.Festival", "Festival")
                        .WithMany("ShowSchedules")
                        .HasForeignKey("FestivalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Festival");
                });

            modelBuilder.Entity("Domain.ShowApplicationReview", b =>
                {
                    b.HasOne("Domain.AppUser", "Reviewer")
                        .WithMany("ShowApplications")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Show", "Show")
                        .WithMany("ApplicationReviews")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewer");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Domain.Theatre", b =>
                {
                    b.HasOne("Domain.AppUser", "Manager")
                        .WithOne("ManagedTheatre")
                        .HasForeignKey("Domain.Theatre", "ManagerId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Domain.TheatreShows", b =>
                {
                    b.HasOne("Domain.Show", "Show")
                        .WithMany("Theatres")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Theatre", "Theatre")
                        .WithMany("Shows")
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("Domain.TheatreShowSchedule", b =>
                {
                    b.HasOne("Domain.Schedule", "Schedule")
                        .WithMany("TheatreShows")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Show", "Show")
                        .WithMany("TheatreSchedules")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Theatre", "Theatre")
                        .WithMany("ShowSchedules")
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Show");

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Navigation("ActingRoles");

                    b.Navigation("AuditionReviews");

                    b.Navigation("Auditions");

                    b.Navigation("ManagedTheatre");

                    b.Navigation("Photos");

                    b.Navigation("ShowApplications");
                });

            modelBuilder.Entity("Domain.Audition", b =>
                {
                    b.Navigation("Auditioners");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Domain.Festival", b =>
                {
                    b.Navigation("ShowSchedules");
                });

            modelBuilder.Entity("Domain.Schedule", b =>
                {
                    b.Navigation("TheatreShows");
                });

            modelBuilder.Entity("Domain.Show", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("ApplicationReviews");

                    b.Navigation("TheatreSchedules");

                    b.Navigation("Theatres");
                });

            modelBuilder.Entity("Domain.ShowRole", b =>
                {
                    b.Navigation("RoleActors");

                    b.Navigation("ShowRoleAuditions");
                });

            modelBuilder.Entity("Domain.Theatre", b =>
                {
                    b.Navigation("FestivalsOrganized");

                    b.Navigation("ShowSchedules");

                    b.Navigation("Shows");
                });
#pragma warning restore 612, 618
        }
    }
}