﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Solution.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20191028215746_SeedDate")]
    partial class SeedDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 2,
                            City = "Oakland",
                            Country = "USA",
                            Rating = 2,
                            Review = "Sunny, mild, rough"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Sayulita",
                            Country = "Mexico",
                            Rating = 4,
                            Review = "Crowded and touristy, but still beautiful and warm."
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Santiago",
                            Country = "Chile",
                            Rating = 3,
                            Review = "Busy, a little smoggy, gorgeous mountains"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "Lagos",
                            Country = "Nigeria",
                            Rating = 5,
                            Review = "Vast, expansive"
                        },
                        new
                        {
                            DestinationId = 6,
                            City = "Cairo",
                            Country = "Eqypt",
                            Rating = 5,
                            Review = "So many incredible places to visit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
