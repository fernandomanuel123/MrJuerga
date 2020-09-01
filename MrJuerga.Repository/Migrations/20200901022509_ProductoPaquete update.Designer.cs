﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MrJuerga.Repository.dbcontext;

namespace MrJuerga.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200901022509_ProductoPaquete update")]
    partial class ProductoPaqueteupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MrJuerga.Entity.Boleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("Fecha");

                    b.Property<float>("Total");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Boletas");
                });

            modelBuilder.Entity("MrJuerga.Entity.Paquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Estado");

                    b.Property<string>("Nombre");

                    b.Property<string>("Precio");

                    b.Property<string>("Stock");

                    b.HasKey("Id");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("MrJuerga.Entity.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Estado");

                    b.Property<string>("Nombre");

                    b.Property<string>("Precio");

                    b.Property<int>("Stock");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("MrJuerga.Entity.ProductoPaquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaqueteId");

                    b.Property<int>("ProductoId");

                    b.HasKey("Id");

                    b.HasIndex("PaqueteId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoPaquetes");
                });

            modelBuilder.Entity("MrJuerga.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Correo");

                    b.Property<string>("Dni");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.Property<string>("Password");

                    b.Property<string>("Rol");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MrJuerga.Entity.Boleta", b =>
                {
                    b.HasOne("MrJuerga.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MrJuerga.Entity.ProductoPaquete", b =>
                {
                    b.HasOne("MrJuerga.Entity.Paquete", "Paquete")
                        .WithMany()
                        .HasForeignKey("PaqueteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MrJuerga.Entity.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}