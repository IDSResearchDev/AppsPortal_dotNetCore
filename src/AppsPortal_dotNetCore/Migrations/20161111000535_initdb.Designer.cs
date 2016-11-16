using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AppsPortal_dotNetCore.Model;

namespace AppsPortal_dotNetCore.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20161111000535_initdb")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.AppDoc", b =>
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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.AppFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Media");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("AppFeatures");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Apps", b =>
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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Banner", b =>
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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Buttons", b =>
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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Feedback", b =>
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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("VideoUrl");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.ProductRelease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppVersion");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Details");

                    b.Property<int>("Order");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductReleases");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Users", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Company");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Buttons", b =>
                {
                    b.HasOne("AppsPortal_dotNetCore.Model.Apps")
                        .WithMany("ButtonDetails")
                        .HasForeignKey("AppsId");

                    b.HasOne("AppsPortal_dotNetCore.Model.Banner")
                        .WithMany("ButtonDetails")
                        .HasForeignKey("BannerId");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.Feedback", b =>
                {
                    b.HasOne("AppsPortal_dotNetCore.Model.Apps")
                        .WithMany("FeedBacks")
                        .HasForeignKey("AppsId");
                });

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.ProductRelease", b =>
                {
                    b.HasOne("AppsPortal_dotNetCore.Model.Product")
                        .WithMany("ReleaseData")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
