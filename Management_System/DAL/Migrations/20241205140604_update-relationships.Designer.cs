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
    [Migration("20241205140604_update-relationships")]
    partial class updaterelationships
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
                            Id = new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"),
                            Description = "numquam",
                            Name = "Kris"
                        },
                        new
                        {
                            Id = new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"),
                            Description = "labore",
                            Name = "Alexane"
                        },
                        new
                        {
                            Id = new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"),
                            Description = "id",
                            Name = "Elnora"
                        },
                        new
                        {
                            Id = new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"),
                            Description = "provident",
                            Name = "Ottis"
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
                            Id = new Guid("65227e4b-e999-441e-ba2f-39f816891ee2"),
                            Description = "in",
                            Name = "SMTP"
                        },
                        new
                        {
                            Id = new Guid("266509a5-aa68-4f99-870c-faae36ed021d"),
                            Description = "repellat",
                            Name = "Cape Verde Escudo"
                        },
                        new
                        {
                            Id = new Guid("f46eb97f-a289-4ec9-b44a-8199ec5f3cce"),
                            Description = "provident",
                            Name = "Keys"
                        },
                        new
                        {
                            Id = new Guid("70909c3c-cdb1-48c9-89fc-33d142efaa4e"),
                            Description = "similique",
                            Name = "out-of-the-box"
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
                            Id = new Guid("1181e072-9161-4099-8b6d-45218ae0ba69"),
                            Description = "officia",
                            Name = "Tunnel",
                            TaskId = new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d")
                        },
                        new
                        {
                            Id = new Guid("bc21e76c-e774-4616-963e-dc43763dfe44"),
                            Description = "perferendis",
                            Name = "compressing",
                            TaskId = new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d")
                        },
                        new
                        {
                            Id = new Guid("d86f571b-4b0d-4c72-8d4f-9a747a939194"),
                            Description = "est",
                            Name = "Concrete",
                            TaskId = new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa")
                        },
                        new
                        {
                            Id = new Guid("1849ecb2-735c-4744-a38f-34f43d9b7892"),
                            Description = "voluptatibus",
                            Name = "Awesome Fresh Computer",
                            TaskId = new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa")
                        },
                        new
                        {
                            Id = new Guid("47af20cf-674d-441f-8eb1-4b2b6bbbfbcf"),
                            Description = "non",
                            Name = "Florida",
                            TaskId = new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54")
                        },
                        new
                        {
                            Id = new Guid("fcdefd5a-f150-471a-855a-7a967f65c0f9"),
                            Description = "praesentium",
                            Name = "communities",
                            TaskId = new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54")
                        },
                        new
                        {
                            Id = new Guid("43bce45b-c861-47eb-a103-2dfb7fe6c278"),
                            Description = "sequi",
                            Name = "Cape Verde Escudo",
                            TaskId = new Guid("8989af17-8064-4e23-b17d-db124db025b4")
                        },
                        new
                        {
                            Id = new Guid("3691bf9f-c54c-44de-bb5f-89a5d2208142"),
                            Description = "alias",
                            Name = "Handcrafted",
                            TaskId = new Guid("8989af17-8064-4e23-b17d-db124db025b4")
                        },
                        new
                        {
                            Id = new Guid("e0afdcb8-9798-44f6-9503-214672dccc29"),
                            Description = "dolorem",
                            Name = "deposit",
                            TaskId = new Guid("14953219-0d06-4883-973d-29c12b2b990b")
                        },
                        new
                        {
                            Id = new Guid("653ff8a8-d593-44d4-af19-0ca811d1af15"),
                            Description = "rerum",
                            Name = "Bedfordshire",
                            TaskId = new Guid("14953219-0d06-4883-973d-29c12b2b990b")
                        },
                        new
                        {
                            Id = new Guid("055ffa58-5a27-4823-a7c7-b3a46dfb2acc"),
                            Description = "voluptatem",
                            Name = "Computers",
                            TaskId = new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b")
                        },
                        new
                        {
                            Id = new Guid("ca106481-10d0-48f0-9bda-2d9f3e522d2f"),
                            Description = "omnis",
                            Name = "payment",
                            TaskId = new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b")
                        },
                        new
                        {
                            Id = new Guid("fda546f7-1359-465c-9a03-6011d3751497"),
                            Description = "ut",
                            Name = "holistic",
                            TaskId = new Guid("03adc899-bf50-46f7-8202-f9a20520b19a")
                        },
                        new
                        {
                            Id = new Guid("c63d6cda-0931-4cc4-9a01-81b987559072"),
                            Description = "consectetur",
                            Name = "Incredible Concrete Car",
                            TaskId = new Guid("03adc899-bf50-46f7-8202-f9a20520b19a")
                        },
                        new
                        {
                            Id = new Guid("70432db3-14bc-4765-bf47-1593f7177a99"),
                            Description = "voluptas",
                            Name = "zero administration",
                            TaskId = new Guid("9a198c3e-e918-4352-b637-29c928894a52")
                        },
                        new
                        {
                            Id = new Guid("c612883e-88b3-40c2-89cd-d097825e9471"),
                            Description = "fugiat",
                            Name = "Forge",
                            TaskId = new Guid("9a198c3e-e918-4352-b637-29c928894a52")
                        },
                        new
                        {
                            Id = new Guid("b795dc90-41c3-43b2-8085-459d86199d92"),
                            Description = "deleniti",
                            Name = "Rustic",
                            TaskId = new Guid("41a0e638-8f44-4820-a348-a9e2274e001e")
                        },
                        new
                        {
                            Id = new Guid("93a3d91e-f7d6-4edc-895c-89b1c6ec67ff"),
                            Description = "facere",
                            Name = "Tajikistan",
                            TaskId = new Guid("41a0e638-8f44-4820-a348-a9e2274e001e")
                        },
                        new
                        {
                            Id = new Guid("f7038e01-a8a1-48c6-99b1-ccc22ecb5bc3"),
                            Description = "illo",
                            Name = "magnetic",
                            TaskId = new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34")
                        },
                        new
                        {
                            Id = new Guid("b5473216-c1e7-4dac-b7d2-c8c5c84ce076"),
                            Description = "rerum",
                            Name = "Intelligent",
                            TaskId = new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34")
                        },
                        new
                        {
                            Id = new Guid("98671b19-c687-4d4a-96f0-3d467c044698"),
                            Description = "totam",
                            Name = "Croatian Kuna",
                            TaskId = new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0")
                        },
                        new
                        {
                            Id = new Guid("b9c68848-3c9c-4733-ab74-92012bbaba21"),
                            Description = "quo",
                            Name = "auxiliary",
                            TaskId = new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0")
                        },
                        new
                        {
                            Id = new Guid("6d50edb1-268e-45d4-8ea9-079eb5a32b85"),
                            Description = "et",
                            Name = "dynamic",
                            TaskId = new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73")
                        },
                        new
                        {
                            Id = new Guid("fb685d7c-98b3-4393-8b1c-1de79fee693e"),
                            Description = "quisquam",
                            Name = "Sleek",
                            TaskId = new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73")
                        },
                        new
                        {
                            Id = new Guid("8017703a-fb33-44f1-9d4e-af88817106ac"),
                            Description = "ut",
                            Name = "core",
                            TaskId = new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f")
                        },
                        new
                        {
                            Id = new Guid("86c2ea39-4c9b-4ce1-bec0-8874ade460d9"),
                            Description = "ratione",
                            Name = "Personal Loan Account",
                            TaskId = new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f")
                        },
                        new
                        {
                            Id = new Guid("674925c8-de1e-4203-89e2-56314389480a"),
                            Description = "suscipit",
                            Name = "Heights",
                            TaskId = new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10")
                        },
                        new
                        {
                            Id = new Guid("f676e02d-a7da-4f55-9ee8-080b2ad45c54"),
                            Description = "in",
                            Name = "orange",
                            TaskId = new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10")
                        },
                        new
                        {
                            Id = new Guid("fe69a484-c728-430d-8087-9e333d797ad5"),
                            Description = "ducimus",
                            Name = "optical",
                            TaskId = new Guid("81f31633-f005-4a84-87dc-eca6078114c4")
                        },
                        new
                        {
                            Id = new Guid("7670a466-4b88-4eaf-8fcd-2b5132a539e5"),
                            Description = "eius",
                            Name = "multimedia",
                            TaskId = new Guid("81f31633-f005-4a84-87dc-eca6078114c4")
                        },
                        new
                        {
                            Id = new Guid("4efeab3e-bff9-4889-901d-fed78d36ce19"),
                            Description = "id",
                            Name = "Alaska",
                            TaskId = new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071")
                        },
                        new
                        {
                            Id = new Guid("f427ae1b-9d6c-42ab-afef-9f995d4efb32"),
                            Description = "assumenda",
                            Name = "installation",
                            TaskId = new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071")
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
                            Id = new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d"),
                            Description = "quis",
                            Name = "Front-line",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("e882e972-2e52-4795-b026-9a0697683984"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"),
                            Description = "aut",
                            Name = "SDD",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("e882e972-2e52-4795-b026-9a0697683984"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54"),
                            Description = "sed",
                            Name = "Port",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("8989af17-8064-4e23-b17d-db124db025b4"),
                            Description = "nostrum",
                            Name = "index",
                            Priority = 2,
                            SerialNumber = 1,
                            TableId = new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("14953219-0d06-4883-973d-29c12b2b990b"),
                            Description = "et",
                            Name = "exploit",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b"),
                            Description = "maiores",
                            Name = "Wooden",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("03adc899-bf50-46f7-8202-f9a20520b19a"),
                            Description = "repellendus",
                            Name = "Pa'anga",
                            Priority = 2,
                            SerialNumber = 1,
                            TableId = new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("9a198c3e-e918-4352-b637-29c928894a52"),
                            Description = "nulla",
                            Name = "Rustic Concrete Pizza",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"),
                            Description = "quia",
                            Name = "Tasty Soft Cheese",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34"),
                            Description = "qui",
                            Name = "Investment Account",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0"),
                            Description = "tenetur",
                            Name = "interface",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73"),
                            Description = "aut",
                            Name = "Lek",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f"),
                            Description = "cupiditate",
                            Name = "Buckinghamshire",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10"),
                            Description = "sequi",
                            Name = "Incredible",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("81f31633-f005-4a84-87dc-eca6078114c4"),
                            Description = "qui",
                            Name = "Ergonomic Cotton Car",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071"),
                            Description = "vel",
                            Name = "Cotton",
                            Priority = 3,
                            SerialNumber = 1,
                            TableId = new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"),
                            TaskEstimation = 1
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
                            Id = new Guid("e882e972-2e52-4795-b026-9a0697683984"),
                            BoardId = new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"),
                            Description = "eos",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"),
                            BoardId = new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"),
                            Description = "exercitationem",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"),
                            BoardId = new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"),
                            Description = "exercitationem",
                            Name = "Backlog"
                        },
                        new
                        {
                            Id = new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"),
                            BoardId = new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"),
                            Description = "sit",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"),
                            BoardId = new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"),
                            Description = "sint",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"),
                            BoardId = new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"),
                            Description = "sint",
                            Name = "Backlog"
                        },
                        new
                        {
                            Id = new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"),
                            BoardId = new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"),
                            Description = "dolores",
                            Name = "Done"
                        },
                        new
                        {
                            Id = new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"),
                            BoardId = new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"),
                            Description = "architecto",
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
                            BoardId = new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"),
                            UserId = new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837")
                        },
                        new
                        {
                            BoardId = new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"),
                            UserId = new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f")
                        },
                        new
                        {
                            BoardId = new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"),
                            UserId = new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68")
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
                            Id = new Guid("3908149a-83f5-490c-8078-02afab7a4236"),
                            Email = "Lilliana_Beier77@yahoo.com",
                            FirstName = "Kali",
                            LastName = "O'Conner"
                        },
                        new
                        {
                            Id = new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837"),
                            Email = "Adrianna20@yahoo.com",
                            FirstName = "Horace",
                            LastName = "Gaylord"
                        },
                        new
                        {
                            Id = new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68"),
                            Email = "Libbie_Fay@hotmail.com",
                            FirstName = "Salvador",
                            LastName = "Yundt"
                        },
                        new
                        {
                            Id = new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f"),
                            Email = "Ashly50@hotmail.com",
                            FirstName = "Mollie",
                            LastName = "Simonis"
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
                            TaskId = new Guid("14953219-0d06-4883-973d-29c12b2b990b"),
                            UserId = new Guid("3908149a-83f5-490c-8078-02afab7a4236"),
                            Role = 0
                        },
                        new
                        {
                            TaskId = new Guid("8989af17-8064-4e23-b17d-db124db025b4"),
                            UserId = new Guid("3908149a-83f5-490c-8078-02afab7a4236"),
                            Role = 2
                        },
                        new
                        {
                            TaskId = new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"),
                            UserId = new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837"),
                            Role = 2
                        },
                        new
                        {
                            TaskId = new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"),
                            UserId = new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f"),
                            Role = 0
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