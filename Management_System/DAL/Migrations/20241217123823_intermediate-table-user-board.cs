using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class intermediatetableuserboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("266509a5-aa68-4f99-870c-faae36ed021d"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("65227e4b-e999-441e-ba2f-39f816891ee2"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("70909c3c-cdb1-48c9-89fc-33d142efaa4e"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("f46eb97f-a289-4ec9-b44a-8199ec5f3cce"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("055ffa58-5a27-4823-a7c7-b3a46dfb2acc"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1181e072-9161-4099-8b6d-45218ae0ba69"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1849ecb2-735c-4744-a38f-34f43d9b7892"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("3691bf9f-c54c-44de-bb5f-89a5d2208142"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("43bce45b-c861-47eb-a103-2dfb7fe6c278"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("47af20cf-674d-441f-8eb1-4b2b6bbbfbcf"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4efeab3e-bff9-4889-901d-fed78d36ce19"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("653ff8a8-d593-44d4-af19-0ca811d1af15"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("674925c8-de1e-4203-89e2-56314389480a"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("6d50edb1-268e-45d4-8ea9-079eb5a32b85"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("70432db3-14bc-4765-bf47-1593f7177a99"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7670a466-4b88-4eaf-8fcd-2b5132a539e5"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8017703a-fb33-44f1-9d4e-af88817106ac"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("86c2ea39-4c9b-4ce1-bec0-8874ade460d9"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("93a3d91e-f7d6-4edc-895c-89b1c6ec67ff"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("98671b19-c687-4d4a-96f0-3d467c044698"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("b5473216-c1e7-4dac-b7d2-c8c5c84ce076"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("b795dc90-41c3-43b2-8085-459d86199d92"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("b9c68848-3c9c-4733-ab74-92012bbaba21"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("bc21e76c-e774-4616-963e-dc43763dfe44"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c612883e-88b3-40c2-89cd-d097825e9471"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c63d6cda-0931-4cc4-9a01-81b987559072"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("ca106481-10d0-48f0-9bda-2d9f3e522d2f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d86f571b-4b0d-4c72-8d4f-9a747a939194"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("e0afdcb8-9798-44f6-9503-214672dccc29"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f427ae1b-9d6c-42ab-afef-9f995d4efb32"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f676e02d-a7da-4f55-9ee8-080b2ad45c54"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f7038e01-a8a1-48c6-99b1-ccc22ecb5bc3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("fb685d7c-98b3-4393-8b1c-1de79fee693e"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("fcdefd5a-f150-471a-855a-7a967f65c0f9"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("fda546f7-1359-465c-9a03-6011d3751497"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("fe69a484-c728-430d-8087-9e333d797ad5"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("e882e972-2e52-4795-b026-9a0697683984"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("03adc899-bf50-46f7-8202-f9a20520b19a"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("81f31633-f005-4a84-87dc-eca6078114c4"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("9a198c3e-e918-4352-b637-29c928894a52"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071"));

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"), new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"), new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("14953219-0d06-4883-973d-29c12b2b990b"), new Guid("3908149a-83f5-490c-8078-02afab7a4236") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"), new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("8989af17-8064-4e23-b17d-db124db025b4"), new Guid("3908149a-83f5-490c-8078-02afab7a4236") });

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("14953219-0d06-4883-973d-29c12b2b990b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8989af17-8064-4e23-b17d-db124db025b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3908149a-83f5-490c-8078-02afab7a4236"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserTasks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserBoards",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "UserBoards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"), "esse", "Walter" },
                    { new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), "hic", "Napoleon" },
                    { new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"), "pariatur", "Kiera" },
                    { new Guid("e0316831-8191-4db2-b0a6-3498afddae06"), "inventore", "Eduardo" }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("22053fee-2f21-4e2c-8d62-2cd6cbce2d67"), "error", "ubiquitous" },
                    { new Guid("4a5599a0-8560-4d71-a80d-31f63830f977"), "impedit", "interface" },
                    { new Guid("5084e3e7-c605-4ff9-8669-d8091244a9ba"), "eligendi", "Response" },
                    { new Guid("8bc74cd7-33be-4636-8778-ac9ea860e129"), "veritatis", "North Dakota" }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "Id", "Description", "Name", "TaskEntityId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("03635de8-9ffc-4ef9-9a0e-5e99e0ca1a8a"), "facilis", "Enhanced", null, new Guid("4d1af4f2-b7c6-440b-baef-54aa91faac75") },
                    { new Guid("06634fcf-5873-4cc0-97cf-654aaec60911"), "perferendis", "Wisconsin", null, new Guid("5fe44b94-c3aa-4d9e-82b1-07840a04b790") },
                    { new Guid("0c6c375f-4016-45ea-a63b-d52d078b5056"), "dignissimos", "International", null, new Guid("d87a9f92-cb25-4b54-9ef9-be91af1b20d2") },
                    { new Guid("1792e3f4-3740-4aae-b70a-8e3ae8e5a0ce"), "voluptatibus", "Fords", null, new Guid("1812e275-d6a6-4af4-8280-ab2a3970102c") },
                    { new Guid("1fa6f701-47cc-4be2-a1b4-7a8cac5e6861"), "sunt", "calculate", null, new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41") },
                    { new Guid("2799db9e-270c-44ec-a78f-a6347a292da0"), "consectetur", "Handmade Rubber Bike", null, new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41") },
                    { new Guid("299d349c-a1cb-4086-81fe-24ba3016fab6"), "blanditiis", "Cambridgeshire", null, new Guid("10755e88-6cfd-4078-9034-1ff57331f396") },
                    { new Guid("2c42815d-db04-49e2-b38d-d87122eb25fa"), "non", "Ergonomic Granite Chair", null, new Guid("6605cbbb-aaa2-4f14-8cbe-54a180492feb") },
                    { new Guid("43bece79-5bda-41fb-a838-34222c44aee6"), "omnis", "object-oriented", null, new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e") },
                    { new Guid("4ada2293-cf6a-40aa-9b60-99030f20e777"), "consectetur", "Parkways", null, new Guid("98ca492a-8041-4327-a4e8-eb4f2a9d2ce4") },
                    { new Guid("522ab2f5-3419-4517-bba6-7781f5f3177b"), "ut", "Bulgaria", null, new Guid("98ca492a-8041-4327-a4e8-eb4f2a9d2ce4") },
                    { new Guid("560ec6d6-4d3b-4325-b130-09381ee2a7a5"), "iusto", "panel", null, new Guid("360b2c7b-906d-4b3d-af5c-2a52f8871856") },
                    { new Guid("6388c064-947f-4724-b96b-6aeffb60ff2c"), "impedit", "deposit", null, new Guid("5fe44b94-c3aa-4d9e-82b1-07840a04b790") },
                    { new Guid("64f363ea-3447-4aa4-81e7-9e4bda99c40a"), "harum", "COM", null, new Guid("586cbf1a-6328-4b6e-8f02-f23a844bd5c8") },
                    { new Guid("66516fd1-08d3-4fce-b37d-5a613c9e2689"), "vel", "Ergonomic Steel Shoes", null, new Guid("4d1af4f2-b7c6-440b-baef-54aa91faac75") },
                    { new Guid("66b28082-77a7-4bb7-a4b9-3790590f97d5"), "ut", "leverage", null, new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2") },
                    { new Guid("68c9f4ba-63d9-4019-a916-e91dbe7bc1c7"), "necessitatibus", "Future-proofed", null, new Guid("360b2c7b-906d-4b3d-af5c-2a52f8871856") },
                    { new Guid("7ab1c5ab-4074-4a94-8d32-a901553a57b7"), "praesentium", "Licensed Cotton Chips", null, new Guid("10755e88-6cfd-4078-9034-1ff57331f396") },
                    { new Guid("8b3a8e76-2550-4dfc-9fed-5c8686d347b7"), "veniam", "Oval", null, new Guid("a86d0f02-291b-4082-8860-00d7f85b9879") },
                    { new Guid("8e92ec31-0fae-4d93-bcc0-a640a4fbdad8"), "vel", "Intelligent", null, new Guid("586cbf1a-6328-4b6e-8f02-f23a844bd5c8") },
                    { new Guid("8efa1b20-63fe-4cad-9aea-b310023eda97"), "illo", "Steel", null, new Guid("a6708a3a-7955-4381-840e-1508883ece57") },
                    { new Guid("9f919842-9749-4413-9e03-637073cf5a48"), "dolores", "extensible", null, new Guid("6605cbbb-aaa2-4f14-8cbe-54a180492feb") },
                    { new Guid("a0130b3a-baab-4767-ad9f-a42142f33ba6"), "architecto", "Innovative", null, new Guid("96504248-aef8-42bc-a080-cc3dea240f5c") },
                    { new Guid("b2e8bffe-48dd-4fbc-a23a-32ed38499941"), "eaque", "cross-platform", null, new Guid("a6708a3a-7955-4381-840e-1508883ece57") },
                    { new Guid("b72b00ad-cf34-4524-a0c8-078a603d1de8"), "eos", "Response", null, new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7") },
                    { new Guid("c00e37b6-d0cf-4965-b6f2-ca5f6d0905e6"), "expedita", "Awesome", null, new Guid("1812e275-d6a6-4af4-8280-ab2a3970102c") },
                    { new Guid("c050d8b4-1216-446f-ad21-61ba2340cc13"), "aut", "program", null, new Guid("96504248-aef8-42bc-a080-cc3dea240f5c") },
                    { new Guid("d17b018d-05b0-490f-a66a-f7ec1e256bb3"), "quod", "local", null, new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e") },
                    { new Guid("d493a641-ab59-45f9-8954-225fa9f513ed"), "quia", "infrastructure", null, new Guid("a86d0f02-291b-4082-8860-00d7f85b9879") },
                    { new Guid("e375bc86-fb30-46e3-b3a1-887e78cc2e6a"), "tempore", "Streets", null, new Guid("d87a9f92-cb25-4b54-9ef9-be91af1b20d2") },
                    { new Guid("e3a809eb-ad59-4298-8d15-fe280e9b16ff"), "ut", "Grocery & Electronics", null, new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2") },
                    { new Guid("f1af67de-2457-4617-b538-0b3199b7f19b"), "voluptatem", "Sierra Leone", null, new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7") }
                });

            migrationBuilder.InsertData(
                table: "TaskStatus",
                columns: new[] { "Id", "BoardEntityId", "BoardId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0f17aee1-32a7-487d-96df-42f9654b22a2"), null, new Guid("e0316831-8191-4db2-b0a6-3498afddae06"), "incidunt", "Done" },
                    { new Guid("357794c5-f0ed-4244-b0b9-15f7e154d600"), null, new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"), "iure", "In Review" },
                    { new Guid("4e67d714-df51-4626-ac3f-e5d68e9b467d"), null, new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"), "debitis", "In Review" },
                    { new Guid("5bf362cd-36fd-4d34-a8d3-010957f157f0"), null, new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), "nostrum", "Done" },
                    { new Guid("9112e278-59c4-4890-9876-914601e689e8"), null, new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"), "odio", "Done" },
                    { new Guid("9de9f7d1-f729-470e-ba06-958592d99e98"), null, new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"), "sint", "Done" },
                    { new Guid("b97d7dec-6090-449f-8ae1-2cd15181a7a6"), null, new Guid("e0316831-8191-4db2-b0a6-3498afddae06"), "quam", "In Review" },
                    { new Guid("bf5359b3-fbe1-4470-8dfa-7369fdd2155a"), null, new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), "ab", "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "LabelEntityId", "Name", "Priority", "SerialNumber", "TableId", "TaskEstimation", "TaskStatusEntityId" },
                values: new object[,]
                {
                    { new Guid("10755e88-6cfd-4078-9034-1ff57331f396"), "deleniti", null, "Walk", 0, 1, new Guid("357794c5-f0ed-4244-b0b9-15f7e154d600"), 0, null },
                    { new Guid("1812e275-d6a6-4af4-8280-ab2a3970102c"), "alias", null, "Concrete", 0, 0, new Guid("bf5359b3-fbe1-4470-8dfa-7369fdd2155a"), 0, null },
                    { new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e"), "ut", null, "hack", 2, 1, new Guid("5bf362cd-36fd-4d34-a8d3-010957f157f0"), 1, null },
                    { new Guid("360b2c7b-906d-4b3d-af5c-2a52f8871856"), "cumque", null, "client-server", 1, 1, new Guid("0f17aee1-32a7-487d-96df-42f9654b22a2"), 2, null },
                    { new Guid("4d1af4f2-b7c6-440b-baef-54aa91faac75"), "dolores", null, "Buckinghamshire", 2, 1, new Guid("b97d7dec-6090-449f-8ae1-2cd15181a7a6"), 0, null },
                    { new Guid("586cbf1a-6328-4b6e-8f02-f23a844bd5c8"), "perspiciatis", null, "SCSI", 1, 0, new Guid("9112e278-59c4-4890-9876-914601e689e8"), 1, null },
                    { new Guid("5fe44b94-c3aa-4d9e-82b1-07840a04b790"), "aliquid", null, "Technician", 0, 1, new Guid("357794c5-f0ed-4244-b0b9-15f7e154d600"), 2, null },
                    { new Guid("6605cbbb-aaa2-4f14-8cbe-54a180492feb"), "est", null, "olive", 0, 0, new Guid("5bf362cd-36fd-4d34-a8d3-010957f157f0"), 2, null },
                    { new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7"), "voluptatibus", null, "convergence", 1, 0, new Guid("0f17aee1-32a7-487d-96df-42f9654b22a2"), 2, null },
                    { new Guid("96504248-aef8-42bc-a080-cc3dea240f5c"), "qui", null, "lavender", 0, 0, new Guid("9112e278-59c4-4890-9876-914601e689e8"), 2, null },
                    { new Guid("98ca492a-8041-4327-a4e8-eb4f2a9d2ce4"), "aliquid", null, "Boliviano boliviano", 0, 0, new Guid("9de9f7d1-f729-470e-ba06-958592d99e98"), 2, null },
                    { new Guid("a6708a3a-7955-4381-840e-1508883ece57"), "ut", null, "deliverables", 0, 1, new Guid("bf5359b3-fbe1-4470-8dfa-7369fdd2155a"), 0, null },
                    { new Guid("a86d0f02-291b-4082-8860-00d7f85b9879"), "cumque", null, "Intranet", 2, 1, new Guid("9de9f7d1-f729-470e-ba06-958592d99e98"), 2, null },
                    { new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2"), "eos", null, "Rustic Wooden Computer", 2, 1, new Guid("4e67d714-df51-4626-ac3f-e5d68e9b467d"), 2, null },
                    { new Guid("d87a9f92-cb25-4b54-9ef9-be91af1b20d2"), "fugiat", null, "Principal", 3, 0, new Guid("4e67d714-df51-4626-ac3f-e5d68e9b467d"), 0, null },
                    { new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41"), "rerum", null, "users", 3, 1, new Guid("b97d7dec-6090-449f-8ae1-2cd15181a7a6"), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc"), "Brigitte86@yahoo.com", "Emie", "Tremblay" },
                    { new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee"), "Kellie_Howe@gmail.com", "Dallin", "Mraz" },
                    { new Guid("9a5c594e-d28c-47c6-a49d-dec0be63c0d9"), "Damon69@gmail.com", "Athena", "Rosenbaum" },
                    { new Guid("a6f6114b-801e-4562-8e44-e74106df1888"), "Armando.Connelly@gmail.com", "Krystina", "Lang" }
                });

            migrationBuilder.InsertData(
                table: "UserBoards",
                columns: new[] { "BoardId", "UserId", "Id", "Role" },
                values: new object[,]
                {
                    { new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee"), new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), new Guid("9a5c594e-d28c-47c6-a49d-dec0be63c0d9"), new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), new Guid("a6f6114b-801e-4562-8e44-e74106df1888"), new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee"), new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId", "Id", "Role" },
                values: new object[,]
                {
                    { new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee"), new Guid("00000000-0000-0000-0000-000000000000"), 2 },
                    { new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7"), new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc"), new Guid("00000000-0000-0000-0000-000000000000"), 2 },
                    { new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2"), new Guid("a6f6114b-801e-4562-8e44-e74106df1888"), new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41"), new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc"), new Guid("00000000-0000-0000-0000-000000000000"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("e0316831-8191-4db2-b0a6-3498afddae06"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("22053fee-2f21-4e2c-8d62-2cd6cbce2d67"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("4a5599a0-8560-4d71-a80d-31f63830f977"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("5084e3e7-c605-4ff9-8669-d8091244a9ba"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("8bc74cd7-33be-4636-8778-ac9ea860e129"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("03635de8-9ffc-4ef9-9a0e-5e99e0ca1a8a"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("06634fcf-5873-4cc0-97cf-654aaec60911"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("0c6c375f-4016-45ea-a63b-d52d078b5056"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1792e3f4-3740-4aae-b70a-8e3ae8e5a0ce"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1fa6f701-47cc-4be2-a1b4-7a8cac5e6861"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2799db9e-270c-44ec-a78f-a6347a292da0"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("299d349c-a1cb-4086-81fe-24ba3016fab6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2c42815d-db04-49e2-b38d-d87122eb25fa"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("43bece79-5bda-41fb-a838-34222c44aee6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4ada2293-cf6a-40aa-9b60-99030f20e777"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("522ab2f5-3419-4517-bba6-7781f5f3177b"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("560ec6d6-4d3b-4325-b130-09381ee2a7a5"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("6388c064-947f-4724-b96b-6aeffb60ff2c"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("64f363ea-3447-4aa4-81e7-9e4bda99c40a"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("66516fd1-08d3-4fce-b37d-5a613c9e2689"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("66b28082-77a7-4bb7-a4b9-3790590f97d5"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("68c9f4ba-63d9-4019-a916-e91dbe7bc1c7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7ab1c5ab-4074-4a94-8d32-a901553a57b7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8b3a8e76-2550-4dfc-9fed-5c8686d347b7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8e92ec31-0fae-4d93-bcc0-a640a4fbdad8"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8efa1b20-63fe-4cad-9aea-b310023eda97"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("9f919842-9749-4413-9e03-637073cf5a48"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a0130b3a-baab-4767-ad9f-a42142f33ba6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("b2e8bffe-48dd-4fbc-a23a-32ed38499941"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("b72b00ad-cf34-4524-a0c8-078a603d1de8"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c00e37b6-d0cf-4965-b6f2-ca5f6d0905e6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c050d8b4-1216-446f-ad21-61ba2340cc13"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d17b018d-05b0-490f-a66a-f7ec1e256bb3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d493a641-ab59-45f9-8954-225fa9f513ed"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("e375bc86-fb30-46e3-b3a1-887e78cc2e6a"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("e3a809eb-ad59-4298-8d15-fe280e9b16ff"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f1af67de-2457-4617-b538-0b3199b7f19b"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("0f17aee1-32a7-487d-96df-42f9654b22a2"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("357794c5-f0ed-4244-b0b9-15f7e154d600"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("4e67d714-df51-4626-ac3f-e5d68e9b467d"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("5bf362cd-36fd-4d34-a8d3-010957f157f0"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("9112e278-59c4-4890-9876-914601e689e8"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("9de9f7d1-f729-470e-ba06-958592d99e98"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("b97d7dec-6090-449f-8ae1-2cd15181a7a6"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf5359b3-fbe1-4470-8dfa-7369fdd2155a"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("10755e88-6cfd-4078-9034-1ff57331f396"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1812e275-d6a6-4af4-8280-ab2a3970102c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("360b2c7b-906d-4b3d-af5c-2a52f8871856"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4d1af4f2-b7c6-440b-baef-54aa91faac75"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("586cbf1a-6328-4b6e-8f02-f23a844bd5c8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5fe44b94-c3aa-4d9e-82b1-07840a04b790"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6605cbbb-aaa2-4f14-8cbe-54a180492feb"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("96504248-aef8-42bc-a080-cc3dea240f5c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("98ca492a-8041-4327-a4e8-eb4f2a9d2ce4"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a6708a3a-7955-4381-840e-1508883ece57"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a86d0f02-291b-4082-8860-00d7f85b9879"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d87a9f92-cb25-4b54-9ef9-be91af1b20d2"));

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), new Guid("9a5c594e-d28c-47c6-a49d-dec0be63c0d9") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"), new Guid("a6f6114b-801e-4562-8e44-e74106df1888") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e"), new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7"), new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2"), new Guid("a6f6114b-801e-4562-8e44-e74106df1888") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41"), new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc") });

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("1588cd3a-d404-4653-8b42-63e449b776ee"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("85be6ea8-8f16-4011-90b2-b6a5e95013a6"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("87b2c1a7-24a9-4b32-86d1-423386dac1da"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2e4e1759-918f-4c5f-92d3-b6ddee841f4e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("75c1c9d7-fec2-4654-ac17-e6ed690529f7"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b47efa51-1d49-4202-a538-b42f61dfefa2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("dc6e1ef1-951d-494c-9d8f-d99a47cd5c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("758e1c59-080f-48b2-8a31-8e15d25843fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92b4d020-8c84-42e2-9c56-de1bc7bc4cee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a5c594e-d28c-47c6-a49d-dec0be63c0d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6f6114b-801e-4562-8e44-e74106df1888"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserTasks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserBoards");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserBoards");

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"), "provident", "Ottis" },
                    { new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"), "id", "Elnora" },
                    { new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), "numquam", "Kris" },
                    { new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"), "labore", "Alexane" }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("266509a5-aa68-4f99-870c-faae36ed021d"), "repellat", "Cape Verde Escudo" },
                    { new Guid("65227e4b-e999-441e-ba2f-39f816891ee2"), "in", "SMTP" },
                    { new Guid("70909c3c-cdb1-48c9-89fc-33d142efaa4e"), "similique", "out-of-the-box" },
                    { new Guid("f46eb97f-a289-4ec9-b44a-8199ec5f3cce"), "provident", "Keys" }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "Id", "Description", "Name", "TaskEntityId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("055ffa58-5a27-4823-a7c7-b3a46dfb2acc"), "voluptatem", "Computers", null, new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b") },
                    { new Guid("1181e072-9161-4099-8b6d-45218ae0ba69"), "officia", "Tunnel", null, new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d") },
                    { new Guid("1849ecb2-735c-4744-a38f-34f43d9b7892"), "voluptatibus", "Awesome Fresh Computer", null, new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa") },
                    { new Guid("3691bf9f-c54c-44de-bb5f-89a5d2208142"), "alias", "Handcrafted", null, new Guid("8989af17-8064-4e23-b17d-db124db025b4") },
                    { new Guid("43bce45b-c861-47eb-a103-2dfb7fe6c278"), "sequi", "Cape Verde Escudo", null, new Guid("8989af17-8064-4e23-b17d-db124db025b4") },
                    { new Guid("47af20cf-674d-441f-8eb1-4b2b6bbbfbcf"), "non", "Florida", null, new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54") },
                    { new Guid("4efeab3e-bff9-4889-901d-fed78d36ce19"), "id", "Alaska", null, new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071") },
                    { new Guid("653ff8a8-d593-44d4-af19-0ca811d1af15"), "rerum", "Bedfordshire", null, new Guid("14953219-0d06-4883-973d-29c12b2b990b") },
                    { new Guid("674925c8-de1e-4203-89e2-56314389480a"), "suscipit", "Heights", null, new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10") },
                    { new Guid("6d50edb1-268e-45d4-8ea9-079eb5a32b85"), "et", "dynamic", null, new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73") },
                    { new Guid("70432db3-14bc-4765-bf47-1593f7177a99"), "voluptas", "zero administration", null, new Guid("9a198c3e-e918-4352-b637-29c928894a52") },
                    { new Guid("7670a466-4b88-4eaf-8fcd-2b5132a539e5"), "eius", "multimedia", null, new Guid("81f31633-f005-4a84-87dc-eca6078114c4") },
                    { new Guid("8017703a-fb33-44f1-9d4e-af88817106ac"), "ut", "core", null, new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f") },
                    { new Guid("86c2ea39-4c9b-4ce1-bec0-8874ade460d9"), "ratione", "Personal Loan Account", null, new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f") },
                    { new Guid("93a3d91e-f7d6-4edc-895c-89b1c6ec67ff"), "facere", "Tajikistan", null, new Guid("41a0e638-8f44-4820-a348-a9e2274e001e") },
                    { new Guid("98671b19-c687-4d4a-96f0-3d467c044698"), "totam", "Croatian Kuna", null, new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0") },
                    { new Guid("b5473216-c1e7-4dac-b7d2-c8c5c84ce076"), "rerum", "Intelligent", null, new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34") },
                    { new Guid("b795dc90-41c3-43b2-8085-459d86199d92"), "deleniti", "Rustic", null, new Guid("41a0e638-8f44-4820-a348-a9e2274e001e") },
                    { new Guid("b9c68848-3c9c-4733-ab74-92012bbaba21"), "quo", "auxiliary", null, new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0") },
                    { new Guid("bc21e76c-e774-4616-963e-dc43763dfe44"), "perferendis", "compressing", null, new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d") },
                    { new Guid("c612883e-88b3-40c2-89cd-d097825e9471"), "fugiat", "Forge", null, new Guid("9a198c3e-e918-4352-b637-29c928894a52") },
                    { new Guid("c63d6cda-0931-4cc4-9a01-81b987559072"), "consectetur", "Incredible Concrete Car", null, new Guid("03adc899-bf50-46f7-8202-f9a20520b19a") },
                    { new Guid("ca106481-10d0-48f0-9bda-2d9f3e522d2f"), "omnis", "payment", null, new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b") },
                    { new Guid("d86f571b-4b0d-4c72-8d4f-9a747a939194"), "est", "Concrete", null, new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa") },
                    { new Guid("e0afdcb8-9798-44f6-9503-214672dccc29"), "dolorem", "deposit", null, new Guid("14953219-0d06-4883-973d-29c12b2b990b") },
                    { new Guid("f427ae1b-9d6c-42ab-afef-9f995d4efb32"), "assumenda", "installation", null, new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071") },
                    { new Guid("f676e02d-a7da-4f55-9ee8-080b2ad45c54"), "in", "orange", null, new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10") },
                    { new Guid("f7038e01-a8a1-48c6-99b1-ccc22ecb5bc3"), "illo", "magnetic", null, new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34") },
                    { new Guid("fb685d7c-98b3-4393-8b1c-1de79fee693e"), "quisquam", "Sleek", null, new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73") },
                    { new Guid("fcdefd5a-f150-471a-855a-7a967f65c0f9"), "praesentium", "communities", null, new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54") },
                    { new Guid("fda546f7-1359-465c-9a03-6011d3751497"), "ut", "holistic", null, new Guid("03adc899-bf50-46f7-8202-f9a20520b19a") },
                    { new Guid("fe69a484-c728-430d-8087-9e333d797ad5"), "ducimus", "optical", null, new Guid("81f31633-f005-4a84-87dc-eca6078114c4") }
                });

            migrationBuilder.InsertData(
                table: "TaskStatus",
                columns: new[] { "Id", "BoardEntityId", "BoardId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"), null, new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"), "architecto", "Backlog" },
                    { new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"), null, new Guid("00d5f841-98ef-4971-9f0d-5e8af87f54d8"), "dolores", "Done" },
                    { new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"), null, new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), "exercitationem", "In Progress" },
                    { new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"), null, new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"), "sint", "In Review" },
                    { new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"), null, new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"), "exercitationem", "Backlog" },
                    { new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"), null, new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"), "sit", "In Progress" },
                    { new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"), null, new Guid("74dd6493-e9e3-4ed9-a010-252ed939c00f"), "sint", "Backlog" },
                    { new Guid("e882e972-2e52-4795-b026-9a0697683984"), null, new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), "eos", "In Review" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "LabelEntityId", "Name", "Priority", "SerialNumber", "TableId", "TaskEstimation", "TaskStatusEntityId" },
                values: new object[,]
                {
                    { new Guid("03adc899-bf50-46f7-8202-f9a20520b19a"), "repellendus", null, "Pa'anga", 2, 1, new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"), 0, null },
                    { new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"), "aut", null, "SDD", 1, 1, new Guid("e882e972-2e52-4795-b026-9a0697683984"), 1, null },
                    { new Guid("1417a381-a3a1-4509-9857-ac2e3c07ab54"), "sed", null, "Port", 0, 0, new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"), 1, null },
                    { new Guid("14953219-0d06-4883-973d-29c12b2b990b"), "et", null, "exploit", 1, 0, new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"), 2, null },
                    { new Guid("3a77a6e5-f431-40e2-9279-7f27b5b5ee73"), "aut", null, "Lek", 1, 0, new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"), 2, null },
                    { new Guid("3e3e0a85-cc40-457c-9bbd-435ca0e31d34"), "qui", null, "Investment Account", 2, 0, new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"), 0, null },
                    { new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"), "quia", null, "Tasty Soft Cheese", 1, 1, new Guid("5610e5a4-357d-4ded-831c-7c7babb241a0"), 0, null },
                    { new Guid("52d5abb9-3352-477c-98f0-aee5795b6c10"), "sequi", null, "Incredible", 2, 0, new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"), 1, null },
                    { new Guid("81f31633-f005-4a84-87dc-eca6078114c4"), "qui", null, "Ergonomic Cotton Car", 3, 0, new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"), 2, null },
                    { new Guid("881aa7e6-d239-4e3a-8e02-5cd996fff99b"), "maiores", null, "Wooden", 1, 1, new Guid("8751ff46-50ed-4793-8248-6eca1906bee8"), 1, null },
                    { new Guid("8989af17-8064-4e23-b17d-db124db025b4"), "nostrum", null, "index", 2, 1, new Guid("4e1ef3af-feec-4e3a-acfc-6be37f0624b5"), 1, null },
                    { new Guid("8a6789d7-d49d-4200-b004-44b763aa6ea0"), "tenetur", null, "interface", 3, 0, new Guid("e7c9e9e7-df0f-4ea3-ba39-3858fdd3b3c8"), 0, null },
                    { new Guid("900537a8-c9d5-4920-8caf-e17fe1e4d31d"), "quis", null, "Front-line", 2, 0, new Guid("e882e972-2e52-4795-b026-9a0697683984"), 2, null },
                    { new Guid("9a198c3e-e918-4352-b637-29c928894a52"), "nulla", null, "Rustic Concrete Pizza", 0, 0, new Guid("cfc9a4e8-5f9a-48e0-b4b6-ae5e0296184f"), 2, null },
                    { new Guid("c74f9dfc-c26e-445b-9af5-8fd9c25a9a4f"), "cupiditate", null, "Buckinghamshire", 2, 0, new Guid("3aa7791e-a958-4845-a815-5cb2e1f1efea"), 2, null },
                    { new Guid("d2ad96d9-f1ea-48cf-b237-4aef9af29071"), "vel", null, "Cotton", 3, 1, new Guid("20de96a2-69ae-4a37-ae9e-b721cfdbaed7"), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837"), "Adrianna20@yahoo.com", "Horace", "Gaylord" },
                    { new Guid("3908149a-83f5-490c-8078-02afab7a4236"), "Lilliana_Beier77@yahoo.com", "Kali", "O'Conner" },
                    { new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68"), "Libbie_Fay@hotmail.com", "Salvador", "Yundt" },
                    { new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f"), "Ashly50@hotmail.com", "Mollie", "Simonis" }
                });

            migrationBuilder.InsertData(
                table: "UserBoards",
                columns: new[] { "BoardId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), new Guid("95e27ee1-3087-48d1-ad20-82bb8c447b68") },
                    { new Guid("e30c3e79-ec4e-40cc-8a97-91c7f8a05858"), new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f") },
                    { new Guid("fe131d51-acb6-47dc-b3fe-d4c0d4dcf87e"), new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId", "Role" },
                values: new object[,]
                {
                    { new Guid("10fc0ada-3127-4dda-868f-93e1aae74faa"), new Guid("17a50d40-4f38-4b18-b246-69e5e83dc837"), 2 },
                    { new Guid("14953219-0d06-4883-973d-29c12b2b990b"), new Guid("3908149a-83f5-490c-8078-02afab7a4236"), 0 },
                    { new Guid("41a0e638-8f44-4820-a348-a9e2274e001e"), new Guid("e45e8ef8-bae3-4ca9-b749-4a2073b4129f"), 0 },
                    { new Guid("8989af17-8064-4e23-b17d-db124db025b4"), new Guid("3908149a-83f5-490c-8078-02afab7a4236"), 2 }
                });
        }
    }
}
