﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoPTI2.Data;

namespace ProjetoPTI2.Migrations
{
    [DbContext(typeof(ProjetoPTI2Context))]
    partial class ProjetoPTI2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoPTI2.Models.CadastroCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj");

                    b.Property<DateTime>("Dt_cadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Telefone");

                    b.Property<int>("TipoLogin");

                    b.HasKey("Id");

                    b.ToTable("tbCliente");
                });

            modelBuilder.Entity("ProjetoPTI2.Models.CadastroFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Dt_Contratacao");

                    b.Property<string>("Email");

                    b.Property<int>("Matricula");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("TipoLogin");

                    b.HasKey("Id");

                    b.ToTable("tbFuncionario");
                });

            modelBuilder.Entity("ProjetoPTI2.Models.Chamado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Dt_abertura");

                    b.Property<DateTime>("Dt_fechamento");

                    b.Property<string>("Resolucao");

                    b.Property<int>("Resolvedor");

                    b.Property<int>("Solicitante");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Chamado");
                });
#pragma warning restore 612, 618
        }
    }
}
