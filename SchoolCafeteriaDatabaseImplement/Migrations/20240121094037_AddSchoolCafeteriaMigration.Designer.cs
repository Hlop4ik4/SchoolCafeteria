﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolCafeteriaDatabaseImplement;

#nullable disable

namespace SchoolCafeteriaDatabaseImplement.Migrations
{
    [DbContext(typeof(SchoolCafeteriaDatabase))]
    [Migration("20240121094037_AddSchoolCafeteriaMigration")]
    partial class AddSchoolCafeteriaMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BruttoMass")
                        .HasColumnType("int");

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<bool>("MarkToDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NettoMass")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId")
                        .IsUnique();

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.GoodsComposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("A")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("B1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("C")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ca")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Carb")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("E")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("GoodsId")
                        .HasColumnType("int");

                    b.Property<decimal>("Mg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("P")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Protein")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TechMapId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GoodsCompositions");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.TechMapGoods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<int>("TechMapId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId");

                    b.HasIndex("TechMapId");

                    b.ToTable("TechMapGoods");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.TechnologicalMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CookingTechnology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeNumber")
                        .HasColumnType("int");

                    b.Property<int>("TechMapId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TechMapId")
                        .IsUnique();

                    b.ToTable("TechnologicalMaps");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.Goods", b =>
                {
                    b.HasOne("SchoolCafeteriaDatabaseImplement.Models.GoodsComposition", "GoodsComposition")
                        .WithOne("Goods")
                        .HasForeignKey("SchoolCafeteriaDatabaseImplement.Models.Goods", "GoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoodsComposition");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.TechMapGoods", b =>
                {
                    b.HasOne("SchoolCafeteriaDatabaseImplement.Models.Goods", "Goods")
                        .WithMany("TechMapGoods")
                        .HasForeignKey("GoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolCafeteriaDatabaseImplement.Models.TechnologicalMap", "TechMap")
                        .WithMany("TechMapGoods")
                        .HasForeignKey("TechMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goods");

                    b.Navigation("TechMap");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.TechnologicalMap", b =>
                {
                    b.HasOne("SchoolCafeteriaDatabaseImplement.Models.GoodsComposition", "GoodsComposition")
                        .WithOne("TechMap")
                        .HasForeignKey("SchoolCafeteriaDatabaseImplement.Models.TechnologicalMap", "TechMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoodsComposition");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.Goods", b =>
                {
                    b.Navigation("TechMapGoods");
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.GoodsComposition", b =>
                {
                    b.Navigation("Goods")
                        .IsRequired();

                    b.Navigation("TechMap")
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolCafeteriaDatabaseImplement.Models.TechnologicalMap", b =>
                {
                    b.Navigation("TechMapGoods");
                });
#pragma warning restore 612, 618
        }
    }
}
