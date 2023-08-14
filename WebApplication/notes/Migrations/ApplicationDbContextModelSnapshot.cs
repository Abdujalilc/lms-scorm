﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenSourceSCORMLMS.Data;

#nullable disable

namespace WebApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.SCORM_Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.Property<string>("SCORM_version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUploaded")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pathToFolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathToIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title_from_manifest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title_from_upload")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("SCORM_Course");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.SCORM_Course_fromSP", b =>
                {
                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("pathToIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_module_id")
                        .HasColumnType("int");

                    b.ToTable("SCORM_Course_FromSP");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.User_Module", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("SCORM_Courseid")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("dScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("dtDateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dtDateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dtDateLastOpened")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dtDatePassed")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("SCORM_Courseid");

                    b.ToTable("User_Module");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_comment_from_learner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("SCORM_courses_id")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("core_id")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("timestamp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("cmi_comment_from_learner");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_comment_from_lms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("SCORM_Course_id")
                        .HasColumnType("int");

                    b.Property<string>("SCO_identifier")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("comment")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("location")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("timestamp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("cmi_comment_from_lms");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", b =>
                {
                    b.Property<int>("core_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("core_id"));

                    b.Property<int?>("SCORM_course_id")
                        .HasColumnType("int");

                    b.Property<string>("completion_status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("credit")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("entry")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("exit")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("lesson_location")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("lesson_mode")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("lesson_status")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("sco_identifier")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("score_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_raw")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_scaled")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("session_time")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("student_id")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("student_name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("success_status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("timestamp")
                        .HasColumnType("datetime");

                    b.Property<string>("total_time")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("core_id");

                    b.ToTable("cmi_core");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_data", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("SCORM_courses_id")
                        .HasColumnType("int");

                    b.Property<string>("cmi_comments")
                        .HasColumnType("text");

                    b.Property<string>("cmi_comments_from_lms")
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("launch_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("mastery_score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("max_time_allowed")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<decimal?>("scaled_passing_score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("sco_id")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("suspend_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("time_limit_action")
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<string>("total_time")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("user_id")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.ToTable("cmi_data");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("core_id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("interaction_time")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("latency")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<Guid?>("msrepl_tran_version")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("n_id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("result")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("student_response")
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timestamp")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("type")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("weighting")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("cmi_interactions");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_correct_responses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("interactions_id")
                        .HasColumnType("int");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("pattern")
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("cmi_interactions_correct_responses");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_objectives", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("interaction_n")
                        .HasColumnType("int");

                    b.Property<int?>("interactions_id")
                        .HasColumnType("int");

                    b.Property<Guid?>("msrepl_tran_version")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("objective_id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.HasIndex("interactions_id");

                    b.ToTable("cmi_interactions_objectives");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_objectives", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("completion_status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("core_id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("msrepl_tran_version")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("n")
                        .HasColumnType("int");

                    b.Property<string>("n_id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("progress_measure")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_raw")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("score_scaled")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("status")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("success_status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("core_id");

                    b.ToTable("cmi_objectives");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_student_preference", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("audio")
                        .HasColumnType("int");

                    b.Property<int?>("audio_captioning")
                        .HasColumnType("int");

                    b.Property<string>("language")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("msrepl_tran_version")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("speed")
                        .HasColumnType("int");

                    b.Property<int?>("text")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("cmi_student_preferences");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.session", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("SCORM_Course_id")
                        .HasColumnType("int");

                    b.Property<string>("SCO_identifier")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("cmi_core_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("enddatetime")
                        .HasColumnType("datetime");

                    b.Property<string>("sessionid")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("startdatetime")
                        .HasColumnType("datetime");

                    b.Property<string>("user_id")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("cmi_core_id");

                    b.ToTable("session");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.User_Module", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.SCORM_Course", "SCORM_Course")
                        .WithMany()
                        .HasForeignKey("SCORM_Courseid");

                    b.Navigation("SCORM_Course");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_objectives", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions", "interactions_")
                        .WithMany("cmi_interactions_objectives")
                        .HasForeignKey("interactions_id");

                    b.Navigation("interactions_");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_objectives", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", "core_")
                        .WithMany("cmi_objectives")
                        .HasForeignKey("core_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("core_");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.session", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", "cmi_core_")
                        .WithMany("session")
                        .HasForeignKey("cmi_core_id");

                    b.Navigation("cmi_core_");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", b =>
                {
                    b.Navigation("cmi_objectives");

                    b.Navigation("session");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions", b =>
                {
                    b.Navigation("cmi_interactions_objectives");
                });
#pragma warning restore 612, 618
        }
    }
}
