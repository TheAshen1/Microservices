﻿// <auto-generated />
using MicroserviceTask.MessagingMicroservice.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroserviceTask.MessengerMicroservice.Migrations
{
    [DbContext(typeof(MessengerContext))]
    [Migration("20181223172005_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("MicroserviceTask.MessagingMicroservice.DataAccess.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<bool>("IsSent");

                    b.Property<string>("Subject");

                    b.Property<string>("_recipients");

                    b.HasKey("Id");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is test message",
                            IsSent = true,
                            Subject = "Test",
                            _recipients = "Max;Anrii;Eugen"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
