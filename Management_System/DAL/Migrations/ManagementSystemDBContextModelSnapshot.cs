﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ManagementSystem.Migrations
{
    [DbContext(typeof(ManagementSystemDBContext))]
    partial class ManagementSystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"),
                            Description = "unde",
                            Name = "Gail"
                        },
                        new
                        {
                            Id = new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"),
                            Description = "similique",
                            Name = "Nils"
                        },
                        new
                        {
                            Id = new Guid("06112724-8dd5-4bda-b90b-ede665639363"),
                            Description = "natus",
                            Name = "Edyth"
                        },
                        new
                        {
                            Id = new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"),
                            Description = "nemo",
                            Name = "Jettie"
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
                            Id = new Guid("e573dd1d-5906-416f-bf03-1fce295a0446"),
                            Description = "eum",
                            Name = "empowering"
                        },
                        new
                        {
                            Id = new Guid("e7a27f55-332c-409b-9105-fef80f62ffd5"),
                            Description = "numquam",
                            Name = "International"
                        },
                        new
                        {
                            Id = new Guid("fbf4948c-7b94-4c32-afac-3c291fc65bb1"),
                            Description = "ex",
                            Name = "plug-and-play"
                        },
                        new
                        {
                            Id = new Guid("189a4c66-bc77-4cf4-b6fd-ea63cb6b778c"),
                            Description = "enim",
                            Name = "Marketing"
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
                            Id = new Guid("f5272147-c44d-418c-8bd9-2ae5a1a3c1f7"),
                            Description = "dolorem",
                            Name = "Dynamic",
                            TaskId = new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b")
                        },
                        new
                        {
                            Id = new Guid("1fe86f6c-1038-41a8-9015-75ec7c009e32"),
                            Description = "explicabo",
                            Name = "California",
                            TaskId = new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b")
                        },
                        new
                        {
                            Id = new Guid("61c48591-f829-40f3-866e-6c3920e8b6ae"),
                            Description = "sed",
                            Name = "Lari",
                            TaskId = new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be")
                        },
                        new
                        {
                            Id = new Guid("880bb697-53ca-4fd7-92c7-ae1449689d02"),
                            Description = "quo",
                            Name = "platforms",
                            TaskId = new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be")
                        },
                        new
                        {
                            Id = new Guid("8c07948c-891a-4c5d-ab2c-05744091ce74"),
                            Description = "enim",
                            Name = "Wooden",
                            TaskId = new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50")
                        },
                        new
                        {
                            Id = new Guid("ea0a1f5a-e82f-43e6-8853-d043881e045b"),
                            Description = "et",
                            Name = "evolve",
                            TaskId = new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50")
                        },
                        new
                        {
                            Id = new Guid("f978c751-c274-4ed1-a72d-418ae057d2ab"),
                            Description = "rerum",
                            Name = "bricks-and-clicks",
                            TaskId = new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0")
                        },
                        new
                        {
                            Id = new Guid("2643970f-193c-49a9-9ea2-b092f837eb5c"),
                            Description = "minus",
                            Name = "Soft",
                            TaskId = new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0")
                        },
                        new
                        {
                            Id = new Guid("3c171c44-42cf-402c-bf40-c69fee0ca58c"),
                            Description = "odio",
                            Name = "Prairie",
                            TaskId = new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f")
                        },
                        new
                        {
                            Id = new Guid("a64e1389-7c65-478a-b402-9c81777e3bcd"),
                            Description = "et",
                            Name = "Computers & Baby",
                            TaskId = new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f")
                        },
                        new
                        {
                            Id = new Guid("8a2e5c1e-6eb8-4f14-8cd8-a2d956d066ff"),
                            Description = "maiores",
                            Name = "innovate",
                            TaskId = new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603")
                        },
                        new
                        {
                            Id = new Guid("263d98c5-bc95-4634-98ae-8612ea569887"),
                            Description = "ut",
                            Name = "Strategist",
                            TaskId = new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603")
                        },
                        new
                        {
                            Id = new Guid("611847de-3ee1-46f5-9781-e4654f5d12ac"),
                            Description = "rerum",
                            Name = "payment",
                            TaskId = new Guid("4d207694-349a-4eba-bf81-eb3869282974")
                        },
                        new
                        {
                            Id = new Guid("448c0973-c78c-4abe-b734-a5e8ce0b3f90"),
                            Description = "voluptas",
                            Name = "Handcrafted Metal Fish",
                            TaskId = new Guid("4d207694-349a-4eba-bf81-eb3869282974")
                        },
                        new
                        {
                            Id = new Guid("7f316050-c441-4176-866c-39d57c244751"),
                            Description = "iste",
                            Name = "orchestrate",
                            TaskId = new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa")
                        },
                        new
                        {
                            Id = new Guid("948be6d8-351c-495b-9f3b-0e90de7dcd66"),
                            Description = "placeat",
                            Name = "Open-architected",
                            TaskId = new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa")
                        },
                        new
                        {
                            Id = new Guid("84ecb298-a61c-4737-85cc-544077909ba5"),
                            Description = "nulla",
                            Name = "exploit",
                            TaskId = new Guid("677bb241-56a9-4a56-9922-37b2f1479e54")
                        },
                        new
                        {
                            Id = new Guid("45d1af29-ed21-4682-9f48-4303bd13071f"),
                            Description = "fuga",
                            Name = "HDD",
                            TaskId = new Guid("677bb241-56a9-4a56-9922-37b2f1479e54")
                        },
                        new
                        {
                            Id = new Guid("f236533b-2e5b-4392-a69b-2337eff71601"),
                            Description = "vitae",
                            Name = "Handcrafted",
                            TaskId = new Guid("560117de-5950-4da3-8037-5008c8ba099c")
                        },
                        new
                        {
                            Id = new Guid("dca72ab5-39bc-466a-a37f-62ac0036e38f"),
                            Description = "placeat",
                            Name = "morph",
                            TaskId = new Guid("560117de-5950-4da3-8037-5008c8ba099c")
                        },
                        new
                        {
                            Id = new Guid("447d6c24-fee2-47b7-9c8a-f21062328e21"),
                            Description = "ea",
                            Name = "Optimization",
                            TaskId = new Guid("26947500-da97-44eb-9109-89e48d9bc8d8")
                        },
                        new
                        {
                            Id = new Guid("9e4f8927-4cd3-46e7-9236-b9ae98755223"),
                            Description = "porro",
                            Name = "Won",
                            TaskId = new Guid("26947500-da97-44eb-9109-89e48d9bc8d8")
                        },
                        new
                        {
                            Id = new Guid("4e331a50-2eeb-4688-b64d-4013b1994b03"),
                            Description = "nam",
                            Name = "CSS",
                            TaskId = new Guid("62e452f8-94fb-4206-85da-b19107d8deef")
                        },
                        new
                        {
                            Id = new Guid("bd796399-4b26-4ec3-ac86-e25e087721e3"),
                            Description = "voluptas",
                            Name = "Toys & Electronics",
                            TaskId = new Guid("62e452f8-94fb-4206-85da-b19107d8deef")
                        },
                        new
                        {
                            Id = new Guid("7db61a62-c7cb-495e-ab26-43d0023030ad"),
                            Description = "repudiandae",
                            Name = "Personal Loan Account",
                            TaskId = new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858")
                        },
                        new
                        {
                            Id = new Guid("c825f73f-d471-46cd-b20e-66488ea211ff"),
                            Description = "nobis",
                            Name = "Focused",
                            TaskId = new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858")
                        },
                        new
                        {
                            Id = new Guid("4e2fd5b0-57ed-465d-b40c-3b74fa64bfb2"),
                            Description = "laboriosam",
                            Name = "Human",
                            TaskId = new Guid("ab113580-3570-437e-992e-c5b045190d96")
                        },
                        new
                        {
                            Id = new Guid("d8603fb9-a559-4b1a-bdab-31283ecae7e3"),
                            Description = "unde",
                            Name = "Zloty",
                            TaskId = new Guid("ab113580-3570-437e-992e-c5b045190d96")
                        },
                        new
                        {
                            Id = new Guid("52a0bfaf-a256-4419-9af8-75a111723696"),
                            Description = "et",
                            Name = "Louisiana",
                            TaskId = new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87")
                        },
                        new
                        {
                            Id = new Guid("75ffdcc5-0e59-4fbf-a65e-23c952300190"),
                            Description = "mollitia",
                            Name = "Fantastic Soft Chicken",
                            TaskId = new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87")
                        },
                        new
                        {
                            Id = new Guid("0d68b57d-7d22-45ef-8481-cd9c991d17e5"),
                            Description = "ut",
                            Name = "parsing",
                            TaskId = new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300")
                        },
                        new
                        {
                            Id = new Guid("92ef39f7-91f6-4aa6-a2f2-72b3609a88e3"),
                            Description = "et",
                            Name = "bypass",
                            TaskId = new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300")
                        });
                });

            modelBuilder.Entity("DAL.Entities.TableEntity", b =>
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

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"),
                            BoardId = new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"),
                            Description = "",
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"),
                            BoardId = new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"),
                            BoardId = new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"),
                            BoardId = new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"),
                            BoardId = new Guid("06112724-8dd5-4bda-b90b-ede665639363"),
                            Description = "",
                            Name = "Backlog"
                        },
                        new
                        {
                            Id = new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"),
                            BoardId = new Guid("06112724-8dd5-4bda-b90b-ede665639363"),
                            Description = "",
                            Name = "In Review"
                        },
                        new
                        {
                            Id = new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"),
                            BoardId = new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"),
                            Description = "",
                            Name = "Backlog"
                        },
                        new
                        {
                            Id = new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"),
                            BoardId = new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"),
                            Description = "",
                            Name = "In Progress"
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

                    b.Property<Guid?>("TableEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uuid");

                    b.Property<int>("TaskEstimation")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LabelEntityId");

                    b.HasIndex("TableEntityId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"),
                            Description = "molestias",
                            Name = "withdrawal",
                            Priority = 2,
                            SerialNumber = 1,
                            TableId = new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"),
                            Description = "dicta",
                            Name = "JBOD",
                            Priority = 3,
                            SerialNumber = 1,
                            TableId = new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50"),
                            Description = "tempora",
                            Name = "Small Cotton Bacon",
                            Priority = 0,
                            SerialNumber = 1,
                            TableId = new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0"),
                            Description = "eum",
                            Name = "knowledge base",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f"),
                            Description = "consequatur",
                            Name = "Solomon Islands Dollar",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603"),
                            Description = "sint",
                            Name = "dynamic",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("4d207694-349a-4eba-bf81-eb3869282974"),
                            Description = "praesentium",
                            Name = "Trail",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"),
                            Description = "qui",
                            Name = "Fantastic Fresh Fish",
                            Priority = 0,
                            SerialNumber = 1,
                            TableId = new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("677bb241-56a9-4a56-9922-37b2f1479e54"),
                            Description = "doloremque",
                            Name = "turquoise",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("560117de-5950-4da3-8037-5008c8ba099c"),
                            Description = "esse",
                            Name = "XML",
                            Priority = 2,
                            SerialNumber = 0,
                            TableId = new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("26947500-da97-44eb-9109-89e48d9bc8d8"),
                            Description = "dolores",
                            Name = "Incredible Steel Computer",
                            Priority = 3,
                            SerialNumber = 0,
                            TableId = new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("62e452f8-94fb-4206-85da-b19107d8deef"),
                            Description = "vel",
                            Name = "payment",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858"),
                            Description = "iure",
                            Name = "Identity",
                            Priority = 1,
                            SerialNumber = 1,
                            TableId = new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"),
                            TaskEstimation = 0
                        },
                        new
                        {
                            Id = new Guid("ab113580-3570-437e-992e-c5b045190d96"),
                            Description = "suscipit",
                            Name = "Shoals",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"),
                            TaskEstimation = 2
                        },
                        new
                        {
                            Id = new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87"),
                            Description = "sed",
                            Name = "Profit-focused",
                            Priority = 0,
                            SerialNumber = 0,
                            TableId = new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"),
                            TaskEstimation = 1
                        },
                        new
                        {
                            Id = new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300"),
                            Description = "minima",
                            Name = "partnerships",
                            Priority = 1,
                            SerialNumber = 0,
                            TableId = new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"),
                            TaskEstimation = 0
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
                            BoardId = new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"),
                            UserId = new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41")
                        },
                        new
                        {
                            BoardId = new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"),
                            UserId = new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05")
                        },
                        new
                        {
                            BoardId = new Guid("06112724-8dd5-4bda-b90b-ede665639363"),
                            UserId = new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05")
                        },
                        new
                        {
                            BoardId = new Guid("06112724-8dd5-4bda-b90b-ede665639363"),
                            UserId = new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836")
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
                            Id = new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41"),
                            Email = "Everette37@yahoo.com",
                            FirstName = "Delmer",
                            LastName = "Botsford"
                        },
                        new
                        {
                            Id = new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"),
                            Email = "Cordia.Nicolas@yahoo.com",
                            FirstName = "Lamar",
                            LastName = "Keebler"
                        },
                        new
                        {
                            Id = new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836"),
                            Email = "Ruthie.Gleichner51@hotmail.com",
                            FirstName = "Marcelo",
                            LastName = "Heidenreich"
                        },
                        new
                        {
                            Id = new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292"),
                            Email = "Maya.Kuhic@yahoo.com",
                            FirstName = "Joanie",
                            LastName = "Metz"
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
                            TaskId = new Guid("4d207694-349a-4eba-bf81-eb3869282974"),
                            UserId = new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41"),
                            Role = 1
                        },
                        new
                        {
                            TaskId = new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"),
                            UserId = new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"),
                            Role = 0
                        },
                        new
                        {
                            TaskId = new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"),
                            UserId = new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292"),
                            Role = 1
                        },
                        new
                        {
                            TaskId = new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"),
                            UserId = new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"),
                            Role = 0
                        });
                });

            modelBuilder.Entity("DAL.Entities.SubtaskEntity", b =>
                {
                    b.HasOne("DAL.Entities.TaskEntity", null)
                        .WithMany("Subtasks")
                        .HasForeignKey("TaskEntityId");
                });

            modelBuilder.Entity("DAL.Entities.TableEntity", b =>
                {
                    b.HasOne("DAL.Entities.BoardEntity", null)
                        .WithMany("Tables")
                        .HasForeignKey("BoardEntityId");
                });

            modelBuilder.Entity("DAL.Entities.TaskEntity", b =>
                {
                    b.HasOne("DAL.Entities.LabelEntity", null)
                        .WithMany("Tasks")
                        .HasForeignKey("LabelEntityId");

                    b.HasOne("DAL.Entities.TableEntity", null)
                        .WithMany("Tasks")
                        .HasForeignKey("TableEntityId");
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
                    b.Navigation("Tables");

                    b.Navigation("UserBoards");
                });

            modelBuilder.Entity("DAL.Entities.LabelEntity", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.TableEntity", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Entities.TaskEntity", b =>
                {
                    b.Navigation("Subtasks");

                    b.Navigation("UserTasks");
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
