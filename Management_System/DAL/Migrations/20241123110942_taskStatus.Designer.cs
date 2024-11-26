﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ManagementSystem.Migrations
{
    [DbContext(typeof(ManagementSystemDBContext))]
    [Migration("20241123110942_taskStatus")]
    partial class taskStatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.BoardEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("787a52e9-7040-4ca8-811a-6d313900e845"),
                            Description = "unde",
                            Name = "Theron"
                        },
                        new
                        {
                            Id = new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"),
                            Description = "velit",
                            Name = "Keshawn"
                        },
                        new
                        {
                            Id = new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"),
                            Description = "qui",
                            Name = "Annalise"
                        },
                        new
                        {
                            Id = new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"),
                            Description = "vero",
                            Name = "Minerva"
                        });
                });

            modelBuilder.Entity("DAL.Entities.LabelEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Labels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4d006956-66fe-4ca5-aa4d-897f06a0f36c"),
                            Description = "rem",
                            Name = "matrix"
                        },
                        new
                        {
                            Id = new Guid("d7afa51c-55cd-4235-9bff-6e3c7f08197c"),
                            Description = "enim",
                            Name = "bus"
                        },
                        new
                        {
                            Id = new Guid("0d43ed9b-040b-4019-9a39-403ec827977e"),
                            Description = "praesentium",
                            Name = "Ford"
                        },
                        new
                        {
                            Id = new Guid("195b620a-4693-4a4c-87b7-765d8ac67eb2"),
                            Description = "qui",
                            Name = "connect"
                        });
                });

            modelBuilder.Entity("DAL.Entities.SubtaskEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("TaskEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TaskEntityId");

                    b.ToTable("Subtasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("690ca44c-f103-4de6-a88b-07bb99fc3a9b"),
                            Description = "ea",
                            Name = "Licensed Concrete Bike",
                            TaskId = new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35")
                        },
                        new
                        {
                            Id = new Guid("a63cd6f9-5f0d-45ec-9cc2-5b993b50b1ba"),
                            Description = "laboriosam",
                            Name = "Human",
                            TaskId = new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35")
                        },
                        new
                        {
                            Id = new Guid("90100b0b-8d3b-4b62-8db2-9034d92e2fbe"),
                            Description = "velit",
                            Name = "Quetzal",
                            TaskId = new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1")
                        },
                        new
                        {
                            Id = new Guid("2a8e9515-f9cb-4360-ba40-fba8b4b07713"),
                            Description = "unde",
                            Name = "Saudi Arabia",
                            TaskId = new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1")
                        },
                        new
                        {
                            Id = new Guid("f56c3a66-e7dd-4c15-b80c-d500604144ce"),
                            Description = "illum",
                            Name = "Mandatory",
                            TaskId = new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f")
                        },
                        new
                        {
                            Id = new Guid("c57e3c0e-2fbc-45e2-8862-0ac8b8e74e69"),
                            Description = "exercitationem",
                            Name = "Bedfordshire",
                            TaskId = new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f")
                        },
                        new
                        {
                            Id = new Guid("6fa35c0c-0f33-4a90-b56f-a87e397301f3"),
                            Description = "non",
                            Name = "ADP",
                            TaskId = new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8")
                        },
                        new
                        {
                            Id = new Guid("d1994ac8-e782-4315-91c5-045433134ad6"),
                            Description = "voluptate",
                            Name = "Pass",
                            TaskId = new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8")
                        },
                        new
                        {
                            Id = new Guid("021d105e-b1cb-4ede-8891-7dfeb04956d7"),
                            Description = "omnis",
                            Name = "Station",
                            TaskId = new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c")
                        },
                        new
                        {
                            Id = new Guid("cbcac5d0-b1b6-4734-9ae0-e7e614a02d94"),
                            Description = "dolore",
                            Name = "array",
                            TaskId = new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c")
                        },
                        new
                        {
                            Id = new Guid("4d08131e-cd32-4b98-8414-ed8dddc42ac2"),
                            Description = "ipsa",
                            Name = "Guinea",
                            TaskId = new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2")
                        },
                        new
                        {
                            Id = new Guid("5433e0c7-79a1-4935-ab6f-d433a08d5708"),
                            Description = "eaque",
                            Name = "SMTP",
                            TaskId = new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2")
                        },
                        new
                        {
                            Id = new Guid("5fbd17d5-86d5-40bf-9c2c-e3e9b366efe7"),
                            Description = "odit",
                            Name = "Grocery",
                            TaskId = new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485")
                        },
                        new
                        {
                            Id = new Guid("3c8b376c-4771-4811-994f-2a7b1bf924b9"),
                            Description = "blanditiis",
                            Name = "Guinea Franc",
                            TaskId = new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485")
                        },
                        new
                        {
                            Id = new Guid("d022b849-e22d-400f-b0a5-eee1d12592e1"),
                            Description = "dolor",
                            Name = "copy",
                            TaskId = new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d")
                        },
                        new
                        {
                            Id = new Guid("e0df03e4-f9cc-4cc9-ac8d-3e392a87c937"),
                            Description = "sint",
                            Name = "Expanded",
                            TaskId = new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d")
                        },
                        new
                        {
                            Id = new Guid("a88321e1-9769-46aa-9279-e0119ce8c603"),
                            Description = "facere",
                            Name = "Credit Card Account",
                            TaskId = new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7")
                        },
                        new
                        {
                            Id = new Guid("c59796a3-77de-4a1b-abba-947da023fdae"),
                            Description = "quas",
                            Name = "silver",
                            TaskId = new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7")
                        },
                        new
                        {
                            Id = new Guid("1f1fd094-f824-420a-83cf-73069948b093"),
                            Description = "qui",
                            Name = "24 hour",
                            TaskId = new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77")
                        },
                        new
                        {
                            Id = new Guid("1c280f73-2d32-44e7-88f6-c2a7c69b4e34"),
                            Description = "sapiente",
                            Name = "utilisation",
                            TaskId = new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77")
                        },
                        new
                        {
                            Id = new Guid("68f5af77-d04b-41bf-be35-ea4d9ffff729"),
                            Description = "quia",
                            Name = "Colombian Peso",
                            TaskId = new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f")
                        },
                        new
                        {
                            Id = new Guid("4cb2bd6b-6953-41f3-857a-81f06d4089be"),
                            Description = "esse",
                            Name = "deposit",
                            TaskId = new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f")
                        },
                        new
                        {
                            Id = new Guid("34f18b5b-f667-4103-a063-cf238cb3b875"),
                            Description = "velit",
                            Name = "innovate",
                            TaskId = new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9")
                        },
                        new
                        {
                            Id = new Guid("a356d6cb-013f-4373-9c6a-fa6fdf6a6be6"),
                            Description = "dolor",
                            Name = "GB",
                            TaskId = new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9")
                        },
                        new
                        {
                            Id = new Guid("2ff15358-9bf5-46bb-8677-c08dbd3cdde7"),
                            Description = "consequatur",
                            Name = "Wells",
                            TaskId = new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02")
                        },
                        new
                        {
                            Id = new Guid("a1d49514-31f0-4941-8f9b-9341d0a200ac"),
                            Description = "odio",
                            Name = "Alaska",
                            TaskId = new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02")
                        },
                        new
                        {
                            Id = new Guid("9bb0b8c0-62a5-4bea-9679-5e4c2e1cea16"),
                            Description = "voluptas",
                            Name = "Branding",
                            TaskId = new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23")
                        },
                        new
                        {
                            Id = new Guid("2b793845-8008-4ef5-814e-3f83af865932"),
                            Description = "rem",
                            Name = "infrastructures",
                            TaskId = new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23")
                        },
                        new
                        {
                            Id = new Guid("6deb9127-7edc-48dd-8621-268cbda51bfb"),
                            Description = "et",
                            Name = "Automotive, Movies & Outdoors",
                            TaskId = new Guid("d270faed-aab1-455f-b5c4-f9263668b78e")
                        },
                        new
                        {
                            Id = new Guid("a376dd3b-88ee-43e5-bdd4-b3b722b4758a"),
                            Description = "ipsam",
                            Name = "black",
                            TaskId = new Guid("d270faed-aab1-455f-b5c4-f9263668b78e")
                        },
                        new
                        {
                            Id = new Guid("a7941f1f-ce93-4f26-b09e-fd4b6d37f8e0"),
                            Description = "libero",
                            Name = "target",
                            TaskId = new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0")
                        },
                        new
                        {
                            Id = new Guid("34db5527-568d-454b-a34e-4ee3b6688dcf"),
                            Description = "ut",
                            Name = "South Africa",
                            TaskId = new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0")
                        });
                });

            modelBuilder.Entity("DAL.Entities.TaskEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LabelEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("integer");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uuid");

                    b.Property<int>("TaskEstimation")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TaskStatusEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LabelEntityId");

                    b.HasIndex("TaskStatusEntityId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35"),
                            Description = "qui",
                            Name = "Stream",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1"),
                            Description = "illo",
                            Name = "compress",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f"),
                            Description = "dolorum",
                            Name = "Operations",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"),
                            Description = "tempora",
                            Name = "Buckinghamshire",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"),
                            Description = "voluptate",
                            Name = "Gorgeous Concrete Computer",
                            Priority = 0,
                            SerialNumber = 1,
                            TableId = new Guid("c47466d9-7713-4482-8034-74941b89dd85"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2"),
                            Description = "in",
                            Name = "Wooden",
                            Priority = 0,
                            SerialNumber = 1,
                            TableId = new Guid("c47466d9-7713-4482-8034-74941b89dd85"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485"),
                            Description = "nihil",
                            Name = "Berkshire",
                            Priority = 3,
                            SerialNumber = 1,
                            TableId = new Guid("94407c38-647c-406c-87ef-ee26d3e73268"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d"),
                            Description = "eos",
                            Name = "Mexican Peso",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("94407c38-647c-406c-87ef-ee26d3e73268"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"),
                            Description = "qui",
                            Name = "support",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77"),
                            Description = "est",
                            Name = "Switchable",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f"),
                            Description = "sequi",
                            Name = "Money Market Account",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9"),
                            Description = "possimus",
                            Name = "Illinois",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02"),
                            Description = "accusamus",
                            Name = "Executive",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23"),
                            Description = "quis",
                            Name = "leverage",
                            Priority = 2,
                            SerialNumber = 1,
                            TableId = new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("d270faed-aab1-455f-b5c4-f9263668b78e"),
                            Description = "rerum",
                            Name = "Diverse",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0"),
                            Description = "distinctio",
                            Name = "Papua New Guinea",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"),
                            TaskEstimation = 0
                        });
                });

            modelBuilder.Entity("DAL.Entities.TaskStatusEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BoardEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BoardId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BoardEntityId");

                    b.ToTable("TaskStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"),
                            BoardId = new Guid("787a52e9-7040-4ca8-811a-6d313900e845"),
                            Description = "",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"),
                            BoardId = new Guid("787a52e9-7040-4ca8-811a-6d313900e845"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("c47466d9-7713-4482-8034-74941b89dd85"),
                            BoardId = new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"),
                            Description = "",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("94407c38-647c-406c-87ef-ee26d3e73268"),
                            BoardId = new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"),
                            BoardId = new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"),
                            Description = "",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"),
                            BoardId = new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"),
                            Description = "",
                            Name = "Backlog"
                        },
                        new
                        {
                            Id = new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"),
                            BoardId = new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"),
                            BoardId = new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"),
                            Description = "",
                            Name = "Backlog"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserBoardEntity", b =>
                {
                    b.Property<Guid>("BoardId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("BoardId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBoards");

                    b.HasData(
                        new
                        {
                            BoardId = new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"),
                            UserId = new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1")
                        },
                        new
                        {
                            BoardId = new Guid("787a52e9-7040-4ca8-811a-6d313900e845"),
                            UserId = new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2")
                        },
                        new
                        {
                            BoardId = new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"),
                            UserId = new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1")
                        },
                        new
                        {
                            BoardId = new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"),
                            UserId = new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93")
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"),
                            Email = "Selena93@hotmail.com",
                            FirstName = "Rogers",
                            LastName = "Schuppe"
                        },
                        new
                        {
                            Id = new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1"),
                            Email = "Marvin.Schaefer@hotmail.com",
                            FirstName = "Kacey",
                            LastName = "Nienow"
                        },
                        new
                        {
                            Id = new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93"),
                            Email = "Quinten.Crooks@yahoo.com",
                            FirstName = "Rogers",
                            LastName = "Zulauf"
                        },
                        new
                        {
                            Id = new Guid("63c11e29-2e11-422e-87dd-60487978a59e"),
                            Email = "Irwin_Hartmann58@gmail.com",
                            FirstName = "Caden",
                            LastName = "Moen"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserTaskEntity", b =>
                {
                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("TaskId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTasks");

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"),
                            UserId = new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1"),
                            Role = 2
                        },
                        new
                        {
                            TaskId = new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"),
                            UserId = new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"),
                            Role = 0
                        },
                        new
                        {
                            TaskId = new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"),
                            UserId = new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93"),
                            Role = 2
                        },
                        new
                        {
                            TaskId = new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"),
                            UserId = new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"),
                            Role = 2
                        });
                });

            modelBuilder.Entity("DAL.Entities.SubtaskEntity", b =>
                {
                    b.HasOne("DAL.Entities.TaskEntity", null)
                        .WithMany("Subtasks")
                        .HasForeignKey("TaskEntityId");
                });

            modelBuilder.Entity("DAL.Entities.TaskEntity", b =>
                {
                    b.HasOne("DAL.Entities.LabelEntity", null)
                        .WithMany("Tasks")
                        .HasForeignKey("LabelEntityId");

                    b.HasOne("DAL.Entities.TaskStatusEntity", null)
                        .WithMany("Tasks")
                        .HasForeignKey("TaskStatusEntityId");
                });

            modelBuilder.Entity("DAL.Entities.TaskStatusEntity", b =>
                {
                    b.HasOne("DAL.Entities.BoardEntity", null)
                        .WithMany("TaskStatus")
                        .HasForeignKey("BoardEntityId");
                });

            modelBuilder.Entity("DAL.Entities.UserBoardEntity", b =>
                {
                    b.HasOne("DAL.Entities.BoardEntity", "Board")
                        .WithMany("UserBoards")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserEntity", "User")
                        .WithMany("UserBoards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.UserTaskEntity", b =>
                {
                    b.HasOne("DAL.Entities.TaskEntity", "Task")
                        .WithMany("UserTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserEntity", "User")
                        .WithMany("UserTasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.BoardEntity", b =>
                {
                    b.Navigation("TaskStatus");

                    b.Navigation("UserBoards");
                });

            modelBuilder.Entity("DAL.Entities.LabelEntity", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.TaskEntity", b =>
                {
                    b.Navigation("Subtasks");

                    b.Navigation("UserTasks");
                });

            modelBuilder.Entity("DAL.Entities.TaskStatusEntity", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("UserBoards");

                    b.Navigation("UserTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
