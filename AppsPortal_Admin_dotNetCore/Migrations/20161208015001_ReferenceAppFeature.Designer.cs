using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AppsPortal.Admin.dotNetCore.Repositories;

namespace AppsPortal_Admin_dotNetCore.Migrations
{
    [DbContext(typeof(AppsContext))]
    [Migration("20161208015001_ReferenceAppFeature")]
    partial class ReferenceAppFeature
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppsPortal.Entities.Model.AppDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("PDFLink");

                    b.Property<string>("Title");

                    b.Property<string>("Topic");

                    b.HasKey("Id");

                    b.ToTable("AppDocs");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.AppFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AppsId");

                    b.Property<string>("Description");

                    b.Property<string>("Media");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AppsId");

                    b.ToTable("AppFeatures");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Apps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Download");

                    b.Property<byte[]>("Icon");

                    b.Property<string>("Media");

                    b.Property<string>("OS");

                    b.Property<string>("SubTitle");

                    b.Property<string>("TeklaVersion");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Context");

                    b.Property<string>("Header");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Buttons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AppsId");

                    b.Property<int?>("BannerId");

                    b.Property<string>("Link");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AppsId");

                    b.HasIndex("BannerId");

                    b.ToTable("Buttons");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AppsId");

                    b.Property<string>("Comment");

                    b.Property<string>("Email");

                    b.Property<string>("Link");

                    b.HasKey("Id");

                    b.HasIndex("AppsId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Users", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Company");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.AppFeature", b =>
                {
                    b.HasOne("AppsPortal.Entities.Model.Apps")
                        .WithMany("AppFeatures")
                        .HasForeignKey("AppsId");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Buttons", b =>
                {
                    b.HasOne("AppsPortal.Entities.Model.Apps")
                        .WithMany("ButtonDetails")
                        .HasForeignKey("AppsId");

                    b.HasOne("AppsPortal.Entities.Model.Banner")
                        .WithMany("ButtonDetails")
                        .HasForeignKey("BannerId");
                });

            modelBuilder.Entity("AppsPortal.Entities.Model.Feedback", b =>
                {
                    b.HasOne("AppsPortal.Entities.Model.Apps")
                        .WithMany("FeedBacks")
                        .HasForeignKey("AppsId");
                });
        }
    }
}
