﻿// <auto-generated />
using System;
using Chat.Domain.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chat.Domain.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    [Migration("20191207030021_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chat.Domain.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FromUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToRoomId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Chat.Domain.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Chat.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Chat.Domain.Models.Message", b =>
                {
                    b.HasOne("Chat.Domain.Models.User", "FromUser")
                        .WithMany("Messages")
                        .HasForeignKey("FromUserId");

                    b.HasOne("Chat.Domain.Models.Room", "ToRoom")
                        .WithMany("Messages")
                        .HasForeignKey("ToRoomId");
                });

            modelBuilder.Entity("Chat.Domain.Models.Room", b =>
                {
                    b.HasOne("Chat.Domain.Models.User", "User")
                        .WithMany("Rooms")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
