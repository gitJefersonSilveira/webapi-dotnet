﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEscola.Data;

#nullable disable

namespace ProjetoEscola.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220409055353_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("ProjetoEscola.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataNasc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = "34/12/2009",
                            Nome = "Carlos",
                            ProfessorId = 1,
                            Sobrenome = "Silva"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = "34/12/2009",
                            Nome = "Juliana",
                            ProfessorId = 2,
                            Sobrenome = "Silva"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = "34/12/2009",
                            Nome = "Zulmira",
                            ProfessorId = 3,
                            Sobrenome = "Silva"
                        });
                });

            modelBuilder.Entity("ProjetoEscola.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Joao Paulo"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Ana Maria"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Cintia"
                        });
                });

            modelBuilder.Entity("ProjetoEscola.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoEscola.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProjetoEscola.Models.Professor", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
