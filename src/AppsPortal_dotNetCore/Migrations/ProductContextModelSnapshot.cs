using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AppsPortal_dotNetCore.Model;

namespace AppsPortal_dotNetCore.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("AppsPortal_dotNetCore.Model.ProductRelease", b =>
                {
                    b.HasOne("AppsPortal_dotNetCore.Model.Product")
                        .WithMany("ReleaseData")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
