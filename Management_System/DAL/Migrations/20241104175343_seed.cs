using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"), "provident", "Mandy" },
                    { new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"), "quia", "Ethyl" },
                    { new Guid("aa48b424-312c-4a46-a00e-bad44db24418"), "sunt", "Saige" },
                    { new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), "ratione", "Fatima" }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("246c4240-9f04-456f-98c3-c9b1b229051a"), "nulla", "Granite" },
                    { new Guid("74928a01-ba48-4683-9558-6f0d04629cf8"), "et", "cross-platform" },
                    { new Guid("9e13186d-7b1f-4826-8e53-fbe8337bfba1"), "quia", "Vermont" },
                    { new Guid("bb0bfe98-39de-4109-bab2-9f6928ba29c9"), "deleniti", "Bypass" }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "Id", "Description", "Name", "TaskEntityId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("0d184789-7a71-4923-a82a-53fc093baf7d"), "tempora", "mission-critical", null, new Guid("d30e4cd3-ef5e-4b40-ab52-5b5fef1dfada") },
                    { new Guid("22d050f7-b7a4-40d5-81a2-e35c978913be"), "ab", "New Hampshire", null, new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f") },
                    { new Guid("25983c6e-bde4-49f0-93c1-cc2d9308a002"), "accusamus", "iterate", null, new Guid("463827a9-6d7f-4c11-a839-8f43801d547e") },
                    { new Guid("39211922-134c-4b25-bad1-d34e7f0e9b14"), "neque", "Idaho", null, new Guid("e21249b5-22e1-452c-a23e-ef39b724fba2") },
                    { new Guid("49a56778-d581-416b-becd-a1f62c45228f"), "deserunt", "Sports & Shoes", null, new Guid("88b32041-da1e-4c0c-b15b-084970697203") },
                    { new Guid("4f8dba1a-126b-4df7-b772-683fb2dc6014"), "nobis", "Borders", null, new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb") },
                    { new Guid("560af9a2-adbb-4286-8460-3a78fd8fbd54"), "excepturi", "Senior", null, new Guid("e21249b5-22e1-452c-a23e-ef39b724fba2") },
                    { new Guid("5d8fd3e2-1adf-4ea2-b743-3d2fc63861d2"), "aut", "quantifying", null, new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb") },
                    { new Guid("60fb2494-5f89-42c4-a6e8-16b8e53f3cdd"), "quas", "JSON", null, new Guid("463827a9-6d7f-4c11-a839-8f43801d547e") },
                    { new Guid("675a0e0e-5de3-4031-8c27-a1c18ee8584f"), "quis", "Refined Steel Chips", null, new Guid("88b32041-da1e-4c0c-b15b-084970697203") },
                    { new Guid("68a8d8e5-f417-4c09-8395-29277a00f9bc"), "iste", "Street", null, new Guid("b956edfb-ad94-4fbb-8b48-091a64808ed5") },
                    { new Guid("7daaf94a-f297-4355-b7a2-29f9154b7ecd"), "iusto", "Awesome Steel Ball", null, new Guid("5b8a9048-d831-46bd-98de-d547bb31b0ec") },
                    { new Guid("7fa5d837-4d5d-44d0-9f92-1f0a9cfd09af"), "quia", "orchid", null, new Guid("1ef13262-56ba-44b9-95d9-65f9f3867748") },
                    { new Guid("862b6b48-fcf7-40a2-b18f-c806b4f9be64"), "et", "enhance", null, new Guid("5b8a9048-d831-46bd-98de-d547bb31b0ec") },
                    { new Guid("884b4b6a-fb0c-408a-a50f-f5bf22381a82"), "temporibus", "bluetooth", null, new Guid("f143b162-2af7-45b6-8d2f-df6dbc6edb6a") },
                    { new Guid("890b4610-031b-4bff-be8d-670a49d876f6"), "molestiae", "Sleek Soft Tuna", null, new Guid("66cedd9d-6e2a-41e2-88b9-cd1cc6663917") },
                    { new Guid("8e90035d-b0e6-4b7b-ab4c-da7824d8560f"), "ipsam", "Generic", null, new Guid("d9378565-188c-423a-90a0-a405e7cdd2b2") },
                    { new Guid("920481fe-118c-47cf-a1dc-1a24c93bca91"), "ipsa", "payment", null, new Guid("43b792da-32ae-44b2-8626-a4034ed3401b") },
                    { new Guid("a0e7d1df-8ca8-4136-8735-262e72edf965"), "sit", "RSS", null, new Guid("f143b162-2af7-45b6-8d2f-df6dbc6edb6a") },
                    { new Guid("a5bce1e5-670b-4cd8-a7cf-60692b0180bc"), "est", "back-end", null, new Guid("d9378565-188c-423a-90a0-a405e7cdd2b2") },
                    { new Guid("ba738a46-7102-47a8-bcfd-79ad36281019"), "cupiditate", "streamline", null, new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f") },
                    { new Guid("bdd355c0-a254-4c58-9623-c97e4c393681"), "harum", "pricing structure", null, new Guid("98970e5b-64a1-4e78-9540-057bddbb0447") },
                    { new Guid("c29c5ec1-1daa-4c4d-a2b1-06aa3ba1593b"), "nemo", "Ohio", null, new Guid("df3e4d06-ccef-49f8-a6e5-805620337255") },
                    { new Guid("d59271ff-48c4-4eef-b185-d54a304cbf04"), "sed", "Kentucky", null, new Guid("43b792da-32ae-44b2-8626-a4034ed3401b") },
                    { new Guid("da25ada7-83c9-4a51-bfdf-93ce0f2be82f"), "quia", "Iowa", null, new Guid("241e871d-8f3f-4cb9-9f42-f0592a89545d") },
                    { new Guid("dc761dfa-5f70-4681-9dec-4f30e01c678d"), "adipisci", "Cambridgeshire", null, new Guid("b956edfb-ad94-4fbb-8b48-091a64808ed5") },
                    { new Guid("dca932fa-4977-4fdc-8d8b-f66e3fb939ff"), "culpa", "Alaska", null, new Guid("df3e4d06-ccef-49f8-a6e5-805620337255") },
                    { new Guid("e43bbb72-5027-4273-8c36-d719c54670ea"), "in", "Rustic Cotton Salad", null, new Guid("66cedd9d-6e2a-41e2-88b9-cd1cc6663917") },
                    { new Guid("f07461f4-31e1-4d5c-88dc-07dab780b2ba"), "quo", "target", null, new Guid("241e871d-8f3f-4cb9-9f42-f0592a89545d") },
                    { new Guid("f69a84aa-9b47-4b2b-8815-748110f437e0"), "officia", "Customer", null, new Guid("1ef13262-56ba-44b9-95d9-65f9f3867748") },
                    { new Guid("f735be83-3539-4d31-9942-8ab5a16f3953"), "ut", "Island", null, new Guid("d30e4cd3-ef5e-4b40-ab52-5b5fef1dfada") },
                    { new Guid("f7f7a38a-a28e-4b1e-8b60-84a6db1d9228"), "excepturi", "Baby", null, new Guid("98970e5b-64a1-4e78-9540-057bddbb0447") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "BoardEntityId", "BoardId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d949b66-c7c6-408e-bc39-39f854c9af44"), null, new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"), "", "In Progress" },
                    { new Guid("1852ff7b-b4cd-47f2-9b8f-fbbe7a7b23ba"), null, new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), "", "Backlog" },
                    { new Guid("1e359fc3-c319-4b7f-9010-a09069944f3b"), null, new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"), "", "Backlog" },
                    { new Guid("412bfb6a-7133-40a6-a537-a1f75cefe9b4"), null, new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"), "", "In Progress" },
                    { new Guid("638eeee1-b56a-4ff0-b66f-453b55e3917e"), null, new Guid("aa48b424-312c-4a46-a00e-bad44db24418"), "", "In Progress" },
                    { new Guid("8fe0f55e-904d-410b-8723-64a98570464c"), null, new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"), "", "Done" },
                    { new Guid("bb7d08e8-1777-4085-8ed2-6c3719b6056f"), null, new Guid("aa48b424-312c-4a46-a00e-bad44db24418"), "", "In Review" },
                    { new Guid("fbd85795-77da-41e1-8b7c-83a0655ec292"), null, new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), "", "Backlog" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "LabelEntityId", "Name", "Priority", "SerialNumber", "TableEntityId", "TableId", "TaskEstimation" },
                values: new object[,]
                {
                    { new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f"), "esse", null, "Berkshire", 1, 1, null, new Guid("412bfb6a-7133-40a6-a537-a1f75cefe9b4"), 0 },
                    { new Guid("1ef13262-56ba-44b9-95d9-65f9f3867748"), "eos", null, "Avon", 1, 0, null, new Guid("412bfb6a-7133-40a6-a537-a1f75cefe9b4"), 2 },
                    { new Guid("241e871d-8f3f-4cb9-9f42-f0592a89545d"), "vero", null, "Handmade Fresh Fish", 2, 1, null, new Guid("1e359fc3-c319-4b7f-9010-a09069944f3b"), 0 },
                    { new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb"), "iusto", null, "fuchsia", 1, 1, null, new Guid("fbd85795-77da-41e1-8b7c-83a0655ec292"), 0 },
                    { new Guid("43b792da-32ae-44b2-8626-a4034ed3401b"), "odit", null, "generating", 1, 1, null, new Guid("8fe0f55e-904d-410b-8723-64a98570464c"), 0 },
                    { new Guid("463827a9-6d7f-4c11-a839-8f43801d547e"), "error", null, "dedicated", 1, 0, null, new Guid("1852ff7b-b4cd-47f2-9b8f-fbbe7a7b23ba"), 2 },
                    { new Guid("5b8a9048-d831-46bd-98de-d547bb31b0ec"), "reprehenderit", null, "revolutionize", 3, 1, null, new Guid("1852ff7b-b4cd-47f2-9b8f-fbbe7a7b23ba"), 1 },
                    { new Guid("66cedd9d-6e2a-41e2-88b9-cd1cc6663917"), "eos", null, "Sharable", 0, 1, null, new Guid("bb7d08e8-1777-4085-8ed2-6c3719b6056f"), 1 },
                    { new Guid("88b32041-da1e-4c0c-b15b-084970697203"), "minima", null, "Dynamic", 1, 0, null, new Guid("8fe0f55e-904d-410b-8723-64a98570464c"), 1 },
                    { new Guid("98970e5b-64a1-4e78-9540-057bddbb0447"), "nobis", null, "Granite", 2, 0, null, new Guid("0d949b66-c7c6-408e-bc39-39f854c9af44"), 0 },
                    { new Guid("b956edfb-ad94-4fbb-8b48-091a64808ed5"), "eaque", null, "Configuration", 3, 1, null, new Guid("bb7d08e8-1777-4085-8ed2-6c3719b6056f"), 2 },
                    { new Guid("d30e4cd3-ef5e-4b40-ab52-5b5fef1dfada"), "et", null, "fault-tolerant", 0, 1, null, new Guid("fbd85795-77da-41e1-8b7c-83a0655ec292"), 2 },
                    { new Guid("d9378565-188c-423a-90a0-a405e7cdd2b2"), "non", null, "program", 2, 1, null, new Guid("1e359fc3-c319-4b7f-9010-a09069944f3b"), 2 },
                    { new Guid("df3e4d06-ccef-49f8-a6e5-805620337255"), "velit", null, "website", 1, 0, null, new Guid("638eeee1-b56a-4ff0-b66f-453b55e3917e"), 1 },
                    { new Guid("e21249b5-22e1-452c-a23e-ef39b724fba2"), "harum", null, "Manager", 1, 1, null, new Guid("638eeee1-b56a-4ff0-b66f-453b55e3917e"), 2 },
                    { new Guid("f143b162-2af7-45b6-8d2f-df6dbc6edb6a"), "sit", null, "USB", 2, 1, null, new Guid("0d949b66-c7c6-408e-bc39-39f854c9af44"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("03d71447-da7c-4ba1-aa3d-bd73fb038bd0"), "Neal_Krajcik@hotmail.com", "Chaz", "Effertz" },
                    { new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a"), "Dallin_Schaden@gmail.com", "Cale", "Connelly" },
                    { new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674"), "Hiram_Oberbrunner36@yahoo.com", "Kendra", "Mann" },
                    { new Guid("ed29892b-1880-408e-bda3-73a6492477bb"), "Boyd43@gmail.com", "Kira", "Maggio" }
                });

            migrationBuilder.InsertData(
                table: "UserBoards",
                columns: new[] { "BoardId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") },
                    { new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") },
                    { new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") },
                    { new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId", "Role" },
                values: new object[,]
                {
                    { new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a"), 1 },
                    { new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674"), 1 },
                    { new Guid("88b32041-da1e-4c0c-b15b-084970697203"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674"), 1 },
                    { new Guid("df3e4d06-ccef-49f8-a6e5-805620337255"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("aa48b424-312c-4a46-a00e-bad44db24418"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("246c4240-9f04-456f-98c3-c9b1b229051a"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("74928a01-ba48-4683-9558-6f0d04629cf8"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("9e13186d-7b1f-4826-8e53-fbe8337bfba1"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("bb0bfe98-39de-4109-bab2-9f6928ba29c9"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("0d184789-7a71-4923-a82a-53fc093baf7d"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("22d050f7-b7a4-40d5-81a2-e35c978913be"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("25983c6e-bde4-49f0-93c1-cc2d9308a002"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("39211922-134c-4b25-bad1-d34e7f0e9b14"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("49a56778-d581-416b-becd-a1f62c45228f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4f8dba1a-126b-4df7-b772-683fb2dc6014"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("560af9a2-adbb-4286-8460-3a78fd8fbd54"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("5d8fd3e2-1adf-4ea2-b743-3d2fc63861d2"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("60fb2494-5f89-42c4-a6e8-16b8e53f3cdd"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("675a0e0e-5de3-4031-8c27-a1c18ee8584f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("68a8d8e5-f417-4c09-8395-29277a00f9bc"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7daaf94a-f297-4355-b7a2-29f9154b7ecd"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7fa5d837-4d5d-44d0-9f92-1f0a9cfd09af"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("862b6b48-fcf7-40a2-b18f-c806b4f9be64"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("884b4b6a-fb0c-408a-a50f-f5bf22381a82"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("890b4610-031b-4bff-be8d-670a49d876f6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8e90035d-b0e6-4b7b-ab4c-da7824d8560f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("920481fe-118c-47cf-a1dc-1a24c93bca91"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a0e7d1df-8ca8-4136-8735-262e72edf965"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a5bce1e5-670b-4cd8-a7cf-60692b0180bc"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("ba738a46-7102-47a8-bcfd-79ad36281019"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("bdd355c0-a254-4c58-9623-c97e4c393681"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c29c5ec1-1daa-4c4d-a2b1-06aa3ba1593b"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d59271ff-48c4-4eef-b185-d54a304cbf04"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("da25ada7-83c9-4a51-bfdf-93ce0f2be82f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("dc761dfa-5f70-4681-9dec-4f30e01c678d"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("dca932fa-4977-4fdc-8d8b-f66e3fb939ff"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("e43bbb72-5027-4273-8c36-d719c54670ea"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f07461f4-31e1-4d5c-88dc-07dab780b2ba"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f69a84aa-9b47-4b2b-8815-748110f437e0"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f735be83-3539-4d31-9942-8ab5a16f3953"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f7f7a38a-a28e-4b1e-8b60-84a6db1d9228"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d949b66-c7c6-408e-bc39-39f854c9af44"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1852ff7b-b4cd-47f2-9b8f-fbbe7a7b23ba"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1e359fc3-c319-4b7f-9010-a09069944f3b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("412bfb6a-7133-40a6-a537-a1f75cefe9b4"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("638eeee1-b56a-4ff0-b66f-453b55e3917e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8fe0f55e-904d-410b-8723-64a98570464c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("bb7d08e8-1777-4085-8ed2-6c3719b6056f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fbd85795-77da-41e1-8b7c-83a0655ec292"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1ef13262-56ba-44b9-95d9-65f9f3867748"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("241e871d-8f3f-4cb9-9f42-f0592a89545d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("43b792da-32ae-44b2-8626-a4034ed3401b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("463827a9-6d7f-4c11-a839-8f43801d547e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5b8a9048-d831-46bd-98de-d547bb31b0ec"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("66cedd9d-6e2a-41e2-88b9-cd1cc6663917"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("98970e5b-64a1-4e78-9540-057bddbb0447"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b956edfb-ad94-4fbb-8b48-091a64808ed5"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d30e4cd3-ef5e-4b40-ab52-5b5fef1dfada"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d9378565-188c-423a-90a0-a405e7cdd2b2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("e21249b5-22e1-452c-a23e-ef39b724fba2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f143b162-2af7-45b6-8d2f-df6dbc6edb6a"));

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f"), new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("88b32041-da1e-4c0c-b15b-084970697203"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("df3e4d06-ccef-49f8-a6e5-805620337255"), new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03d71447-da7c-4ba1-aa3d-bd73fb038bd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed29892b-1880-408e-bda3-73a6492477bb"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("3cd452d2-ed7f-4962-ae1e-3fd3cdbdc0a6"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("a36735a2-4fa8-46f7-b828-667bd41e26ac"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("f2061cb9-47e2-4c5a-a9a3-b203028d39c0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1d5a2dd5-7ee4-434e-870e-c4f392ea4c2f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("29b1833f-3d57-491c-942f-fdb61f5b5ffb"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("88b32041-da1e-4c0c-b15b-084970697203"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("df3e4d06-ccef-49f8-a6e5-805620337255"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a77520f-faf9-47cc-9f2d-24dc37d7907a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5121d59f-82d3-4541-b7a3-ed47ae8db674"));
        }
    }
}
