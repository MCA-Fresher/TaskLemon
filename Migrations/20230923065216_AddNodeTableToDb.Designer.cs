﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(NodeDbContext))]
    [Migration("20230923065216_AddNodeTableToDb")]
    partial class AddNodeTableToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("WebApplication1.Models.Node", b =>
                {
                    b.Property<int>("nodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nodeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("parentNodeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("startdate")
                        .HasColumnType("TEXT");

                    b.HasKey("nodeId");

                    b.ToTable("Nodes");
                });
#pragma warning restore 612, 618
        }
    }
}
