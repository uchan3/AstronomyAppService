﻿// <auto-generated />
using Astronomy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Astronomy.Data.Migrations
{
    [DbContext(typeof(AstronomyDbContext))]
    partial class AstronomyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Astronomy.Data.Models.DeepSkyEntity", b =>
                {
                    b.Property<int>("DeepSkyPKey")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeepSkyInfo")
                        .IsRequired();

                    b.Property<string>("NGCID")
                        .IsRequired();

                    b.HasKey("DeepSkyPKey");

                    b.ToTable("DeepSkyList");
                });
#pragma warning restore 612, 618
        }
    }
}
