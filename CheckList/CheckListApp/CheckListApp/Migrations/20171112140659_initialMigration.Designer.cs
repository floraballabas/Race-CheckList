using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CheckListApp.Entities;
using CheckListApp.Models;

namespace CheckListApp.Migrations
{
    [DbContext(typeof(ItemContext))]
    [Migration("20171112140659_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheckListApp.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPacked");

                    b.Property<string>("Name");

                    b.Property<int>("RaceCategory");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
        }
    }
}
