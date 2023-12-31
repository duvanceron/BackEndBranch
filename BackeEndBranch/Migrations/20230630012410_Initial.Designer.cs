﻿// <auto-generated />
using BackeEndBranch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackeEndBranch.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230630012410_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackeEndBranch.Models.Branch", b =>
                {
                    b.Property<int>("CodeBranch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeBranch"));

                    b.Property<string>("AdressBranch")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DateBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionBranch")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("FKMoneyBranch")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationBranch")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodeBranch");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("BackeEndBranch.Models.Coin", b =>
                {
                    b.Property<int>("IdCoin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCoin"));

                    b.Property<string>("DescriptionCoin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCoin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StateCoin")
                        .HasColumnType("bit");

                    b.HasKey("IdCoin");

                    b.ToTable("Coins");
                });
#pragma warning restore 612, 618
        }
    }
}
