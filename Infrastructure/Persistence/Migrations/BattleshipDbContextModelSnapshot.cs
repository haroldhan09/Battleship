﻿// <auto-generated />
using System;
using Battleship.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Battleship.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BattleshipDbContext))]
    partial class BattleshipDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("Battleship.Persistence.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47fab74f-f962-4ede-820b-2c978502e0fa"),
                            Email = "battleship-admin@bluehourgames.com",
                            IsAdmin = true,
                            IsVerified = true,
                            Name = "Admin",
                            PasswordHash = new byte[] { 24, 26, 70, 51, 35, 233, 135, 70, 154, 150, 196, 215, 144, 48, 234, 198, 115, 142, 53, 201, 49, 91, 162, 239, 95, 75, 56, 129, 29, 12, 100, 60, 74, 106, 242, 143, 121, 58, 40, 85, 251, 175, 99, 82, 131, 25, 210, 57, 148, 191, 167, 147, 149, 103, 44, 210, 144, 15, 161, 86, 111, 30, 14, 159 }
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
