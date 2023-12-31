﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenSourceSCORMLMS.Data;

namespace OpenSourceSCORMLMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181109164536_New-table-user-module")]
    partial class Newtableusermodule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_comment_from_learner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SCORM_courses_id");

                    b.Property<string>("comment")
                        .HasMaxLength(4000);

                    b.Property<int?>("core_id");

                    b.Property<string>("location")
                        .HasMaxLength(250);

                    b.Property<int?>("n");

                    b.Property<string>("timestamp")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("cmi_comment_from_learner");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_comment_from_lms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SCORM_Course_id");

                    b.Property<string>("SCO_identifier")
                        .HasMaxLength(255);

                    b.Property<string>("comment")
                        .HasMaxLength(4000);

                    b.Property<string>("location")
                        .HasMaxLength(250);

                    b.Property<int?>("n");

                    b.Property<string>("timestamp")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("cmi_comment_from_lms");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", b =>
                {
                    b.Property<int>("core_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SCORM_course_id");

                    b.Property<string>("completion_status")
                        .HasMaxLength(20);

                    b.Property<string>("credit")
                        .HasMaxLength(9);

                    b.Property<string>("entry")
                        .HasMaxLength(9);

                    b.Property<string>("exit")
                        .HasMaxLength(8);

                    b.Property<string>("lesson_location")
                        .HasMaxLength(1000);

                    b.Property<string>("lesson_mode")
                        .HasMaxLength(6);

                    b.Property<string>("lesson_status")
                        .HasMaxLength(13);

                    b.Property<string>("sco_identifier")
                        .HasMaxLength(255);

                    b.Property<decimal?>("score_max");

                    b.Property<decimal?>("score_min");

                    b.Property<decimal?>("score_raw");

                    b.Property<decimal?>("score_scaled");

                    b.Property<string>("session_time")
                        .HasMaxLength(20);

                    b.Property<string>("student_id")
                        .HasMaxLength(450);

                    b.Property<string>("student_name")
                        .HasMaxLength(255);

                    b.Property<string>("success_status")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("timestamp")
                        .HasColumnType("datetime");

                    b.Property<string>("total_time")
                        .HasMaxLength(20);

                    b.HasKey("core_id");

                    b.ToTable("cmi_core");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_data", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SCORM_courses_id");

                    b.Property<string>("cmi_comments")
                        .HasColumnType("text");

                    b.Property<string>("cmi_comments_from_lms")
                        .HasMaxLength(8000);

                    b.Property<string>("launch_data")
                        .HasMaxLength(8000);

                    b.Property<decimal?>("mastery_score");

                    b.Property<string>("max_time_allowed")
                        .HasMaxLength(14);

                    b.Property<decimal?>("scaled_passing_score");

                    b.Property<string>("sco_id")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("suspend_data")
                        .HasMaxLength(8000);

                    b.Property<string>("time_limit_action")
                        .HasMaxLength(19);

                    b.Property<string>("total_time")
                        .HasMaxLength(50);

                    b.Property<string>("user_id")
                        .HasMaxLength(450);

                    b.HasKey("id");

                    b.ToTable("cmi_data");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("core_id");

                    b.Property<string>("description")
                        .HasMaxLength(255);

                    b.Property<string>("interaction_time")
                        .HasMaxLength(50);

                    b.Property<string>("latency")
                        .HasMaxLength(13);

                    b.Property<Guid>("msrepl_tran_version");

                    b.Property<int?>("n");

                    b.Property<string>("n_id")
                        .HasMaxLength(255);

                    b.Property<string>("result")
                        .HasMaxLength(13);

                    b.Property<string>("student_response")
                        .HasMaxLength(8000);

                    b.Property<string>("timestamp")
                        .HasMaxLength(20);

                    b.Property<string>("type")
                        .HasMaxLength(11);

                    b.Property<string>("weighting")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("cmi_interactions");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_correct_responses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("interactions_id");

                    b.Property<int?>("n");

                    b.Property<string>("pattern")
                        .HasMaxLength(8000);

                    b.HasKey("id");

                    b.ToTable("cmi_interactions_correct_responses");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_objectives", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("interaction_n");

                    b.Property<int?>("interactions_id");

                    b.Property<Guid>("msrepl_tran_version");

                    b.Property<int?>("n");

                    b.Property<string>("objective_id")
                        .HasMaxLength(255);

                    b.HasKey("id");

                    b.HasIndex("interactions_id");

                    b.ToTable("cmi_interactions_objectives");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_objectives", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("completion_status")
                        .HasMaxLength(20);

                    b.Property<int>("core_id");

                    b.Property<string>("description")
                        .HasMaxLength(250);

                    b.Property<Guid>("msrepl_tran_version");

                    b.Property<int?>("n");

                    b.Property<string>("n_id")
                        .HasMaxLength(255);

                    b.Property<decimal?>("progress_measure");

                    b.Property<decimal?>("score_max");

                    b.Property<decimal?>("score_min");

                    b.Property<decimal?>("score_raw");

                    b.Property<decimal?>("score_scaled");

                    b.Property<string>("status")
                        .HasMaxLength(14);

                    b.Property<string>("success_status")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.HasIndex("core_id");

                    b.ToTable("cmi_objectives");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_student_preference", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("audio");

                    b.Property<int?>("audio_captioning");

                    b.Property<string>("language")
                        .HasMaxLength(255);

                    b.Property<Guid>("msrepl_tran_version");

                    b.Property<int?>("speed");

                    b.Property<int?>("text");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("cmi_student_preferences");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.SCORM_Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUploaded");

                    b.Property<string>("SCORM_version");

                    b.Property<string>("UserUploaded")
                        .HasMaxLength(450);

                    b.Property<string>("pathToFolder");

                    b.Property<string>("pathToIndex");

                    b.Property<string>("title_from_manifest");

                    b.Property<string>("title_from_upload");

                    b.HasKey("id");

                    b.ToTable("SCORM_Course");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.session", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SCORM_Course_id");

                    b.Property<string>("SCO_identifier")
                        .HasMaxLength(100);

                    b.Property<int?>("cmi_core_id");

                    b.Property<DateTime?>("enddatetime")
                        .HasColumnType("datetime");

                    b.Property<string>("sessionid")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("startdatetime")
                        .HasColumnType("datetime");

                    b.Property<string>("user_id")
                        .HasMaxLength(450);

                    b.HasKey("id");

                    b.HasIndex("cmi_core_id");

                    b.ToTable("session");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.User_Module", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SCORM_Courseid");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<decimal>("dScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("dtDateAdded");

                    b.Property<DateTime?>("dtDateCompleted");

                    b.Property<DateTime?>("dtDateLastOpened");

                    b.Property<DateTime?>("dtDatePassed");

                    b.HasKey("id");

                    b.HasIndex("SCORM_Courseid");

                    b.ToTable("User_Module");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions_objectives", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_interactions", "interactions_")
                        .WithMany("cmi_interactions_objectives")
                        .HasForeignKey("interactions_id");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_objectives", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", "core_")
                        .WithMany("cmi_objectives")
                        .HasForeignKey("core_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.session", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.cmi_core", "cmi_core_")
                        .WithMany("session")
                        .HasForeignKey("cmi_core_id");
                });

            modelBuilder.Entity("OpenSourceSCORMLMS.Data.ModelSCORM.User_Module", b =>
                {
                    b.HasOne("OpenSourceSCORMLMS.Data.ModelSCORM.SCORM_Course", "SCORM_Course")
                        .WithMany()
                        .HasForeignKey("SCORM_Courseid");
                });
#pragma warning restore 612, 618
        }
    }
}
