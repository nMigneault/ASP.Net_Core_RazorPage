// <auto-generated />
using System;
using EvalFinale_Natacha.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvalFinale_Natacha.Migrations
{
    [DbContext(typeof(EvalFinale_NatachaContext))]
    [Migration("20220715193606_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvalFinale_Natacha.Modeles.CommandesFaitesPar", b =>
                {
                    b.Property<int>("CommandeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommandeID"), 1L, 1);

                    b.Property<string>("AdresseEnvoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostalEnvoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnvoi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRequise")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeID")
                        .HasColumnType("int");

                    b.Property<string>("PaysEnvoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VilleEnvoi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandeID");

                    b.ToTable("CommandesFaitesPar");
                });
#pragma warning restore 612, 618
        }
    }
}
