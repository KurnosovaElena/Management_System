using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class updaterelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("0d43ed9b-040b-4019-9a39-403ec827977e"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("195b620a-4693-4a4c-87b7-765d8ac67eb2"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("4d006956-66fe-4ca5-aa4d-897f06a0f36c"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("d7afa51c-55cd-4235-9bff-6e3c7f08197c"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("021d105e-b1cb-4ede-8891-7dfeb04956d7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1c280f73-2d32-44e7-88f6-c2a7c69b4e34"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1f1fd094-f824-420a-83cf-73069948b093"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2a8e9515-f9cb-4360-ba40-fba8b4b07713"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2b793845-8008-4ef5-814e-3f83af865932"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2ff15358-9bf5-46bb-8677-c08dbd3cdde7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("34db5527-568d-454b-a34e-4ee3b6688dcf"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("34f18b5b-f667-4103-a063-cf238cb3b875"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("3c8b376c-4771-4811-994f-2a7b1bf924b9"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4cb2bd6b-6953-41f3-857a-81f06d4089be"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4d08131e-cd32-4b98-8414-ed8dddc42ac2"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("5433e0c7-79a1-4935-ab6f-d433a08d5708"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("5fbd17d5-86d5-40bf-9c2c-e3e9b366efe7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("68f5af77-d04b-41bf-be35-ea4d9ffff729"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("690ca44c-f103-4de6-a88b-07bb99fc3a9b"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("6deb9127-7edc-48dd-8621-268cbda51bfb"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("6fa35c0c-0f33-4a90-b56f-a87e397301f3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("90100b0b-8d3b-4b62-8db2-9034d92e2fbe"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("9bb0b8c0-62a5-4bea-9679-5e4c2e1cea16"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a1d49514-31f0-4941-8f9b-9341d0a200ac"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a356d6cb-013f-4373-9c6a-fa6fdf6a6be6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a376dd3b-88ee-43e5-bdd4-b3b722b4758a"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a63cd6f9-5f0d-45ec-9cc2-5b993b50b1ba"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a7941f1f-ce93-4f26-b09e-fd4b6d37f8e0"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a88321e1-9769-46aa-9279-e0119ce8c603"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c57e3c0e-2fbc-45e2-8862-0ac8b8e74e69"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c59796a3-77de-4a1b-abba-947da023fdae"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("cbcac5d0-b1b6-4734-9ae0-e7e614a02d94"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d022b849-e22d-400f-b0a5-eee1d12592e1"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d1994ac8-e782-4315-91c5-045433134ad6"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("e0df03e4-f9cc-4cc9-ac8d-3e392a87c937"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f56c3a66-e7dd-4c15-b80c-d500604144ce"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("94407c38-647c-406c-87ef-ee26d3e73268"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("c47466d9-7713-4482-8034-74941b89dd85"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d270faed-aab1-455f-b5c4-f9263668b78e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9"));

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("787a52e9-7040-4ca8-811a-6d313900e845"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"), new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63c11e29-2e11-422e-87dd-60487978a59e"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("787a52e9-7040-4ca8-811a-6d313900e845"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), "vero", "Minerva" },
                    { new Guid("787a52e9-7040-4ca8-811a-6d313900e845"), "unde", "Theron" },
                    { new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"), "qui", "Annalise" },
                    { new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"), "velit", "Keshawn" }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d43ed9b-040b-4019-9a39-403ec827977e"), "praesentium", "Ford" },
                    { new Guid("195b620a-4693-4a4c-87b7-765d8ac67eb2"), "qui", "connect" },
                    { new Guid("4d006956-66fe-4ca5-aa4d-897f06a0f36c"), "rem", "matrix" },
                    { new Guid("d7afa51c-55cd-4235-9bff-6e3c7f08197c"), "enim", "bus" }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "Id", "Description", "Name", "TaskEntityId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("021d105e-b1cb-4ede-8891-7dfeb04956d7"), "omnis", "Station", null, new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c") },
                    { new Guid("1c280f73-2d32-44e7-88f6-c2a7c69b4e34"), "sapiente", "utilisation", null, new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77") },
                    { new Guid("1f1fd094-f824-420a-83cf-73069948b093"), "qui", "24 hour", null, new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77") },
                    { new Guid("2a8e9515-f9cb-4360-ba40-fba8b4b07713"), "unde", "Saudi Arabia", null, new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1") },
                    { new Guid("2b793845-8008-4ef5-814e-3f83af865932"), "rem", "infrastructures", null, new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23") },
                    { new Guid("2ff15358-9bf5-46bb-8677-c08dbd3cdde7"), "consequatur", "Wells", null, new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02") },
                    { new Guid("34db5527-568d-454b-a34e-4ee3b6688dcf"), "ut", "South Africa", null, new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0") },
                    { new Guid("34f18b5b-f667-4103-a063-cf238cb3b875"), "velit", "innovate", null, new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9") },
                    { new Guid("3c8b376c-4771-4811-994f-2a7b1bf924b9"), "blanditiis", "Guinea Franc", null, new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485") },
                    { new Guid("4cb2bd6b-6953-41f3-857a-81f06d4089be"), "esse", "deposit", null, new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f") },
                    { new Guid("4d08131e-cd32-4b98-8414-ed8dddc42ac2"), "ipsa", "Guinea", null, new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2") },
                    { new Guid("5433e0c7-79a1-4935-ab6f-d433a08d5708"), "eaque", "SMTP", null, new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2") },
                    { new Guid("5fbd17d5-86d5-40bf-9c2c-e3e9b366efe7"), "odit", "Grocery", null, new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485") },
                    { new Guid("68f5af77-d04b-41bf-be35-ea4d9ffff729"), "quia", "Colombian Peso", null, new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f") },
                    { new Guid("690ca44c-f103-4de6-a88b-07bb99fc3a9b"), "ea", "Licensed Concrete Bike", null, new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35") },
                    { new Guid("6deb9127-7edc-48dd-8621-268cbda51bfb"), "et", "Automotive, Movies & Outdoors", null, new Guid("d270faed-aab1-455f-b5c4-f9263668b78e") },
                    { new Guid("6fa35c0c-0f33-4a90-b56f-a87e397301f3"), "non", "ADP", null, new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8") },
                    { new Guid("90100b0b-8d3b-4b62-8db2-9034d92e2fbe"), "velit", "Quetzal", null, new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1") },
                    { new Guid("9bb0b8c0-62a5-4bea-9679-5e4c2e1cea16"), "voluptas", "Branding", null, new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23") },
                    { new Guid("a1d49514-31f0-4941-8f9b-9341d0a200ac"), "odio", "Alaska", null, new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02") },
                    { new Guid("a356d6cb-013f-4373-9c6a-fa6fdf6a6be6"), "dolor", "GB", null, new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9") },
                    { new Guid("a376dd3b-88ee-43e5-bdd4-b3b722b4758a"), "ipsam", "black", null, new Guid("d270faed-aab1-455f-b5c4-f9263668b78e") },
                    { new Guid("a63cd6f9-5f0d-45ec-9cc2-5b993b50b1ba"), "laboriosam", "Human", null, new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35") },
                    { new Guid("a7941f1f-ce93-4f26-b09e-fd4b6d37f8e0"), "libero", "target", null, new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0") },
                    { new Guid("a88321e1-9769-46aa-9279-e0119ce8c603"), "facere", "Credit Card Account", null, new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7") },
                    { new Guid("c57e3c0e-2fbc-45e2-8862-0ac8b8e74e69"), "exercitationem", "Bedfordshire", null, new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f") },
                    { new Guid("c59796a3-77de-4a1b-abba-947da023fdae"), "quas", "silver", null, new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7") },
                    { new Guid("cbcac5d0-b1b6-4734-9ae0-e7e614a02d94"), "dolore", "array", null, new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c") },
                    { new Guid("d022b849-e22d-400f-b0a5-eee1d12592e1"), "dolor", "copy", null, new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d") },
                    { new Guid("d1994ac8-e782-4315-91c5-045433134ad6"), "voluptate", "Pass", null, new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8") },
                    { new Guid("e0df03e4-f9cc-4cc9-ac8d-3e392a87c937"), "sint", "Expanded", null, new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d") },
                    { new Guid("f56c3a66-e7dd-4c15-b80c-d500604144ce"), "illum", "Mandatory", null, new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f") }
                });

            migrationBuilder.InsertData(
                table: "TaskStatus",
                columns: new[] { "Id", "BoardEntityId", "BoardId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"), null, new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"), "", "In Progress" },
                    { new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"), null, new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), "", "In Review" },
                    { new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"), null, new Guid("787a52e9-7040-4ca8-811a-6d313900e845"), "", "In Progress" },
                    { new Guid("94407c38-647c-406c-87ef-ee26d3e73268"), null, new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"), "", "In Review" },
                    { new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"), null, new Guid("787a52e9-7040-4ca8-811a-6d313900e845"), "", "In Review" },
                    { new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"), null, new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), "", "Backlog" },
                    { new Guid("c47466d9-7713-4482-8034-74941b89dd85"), null, new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"), "", "In Progress" },
                    { new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"), null, new Guid("9cddc7db-1849-40e6-abf3-f81b79e61967"), "", "Backlog" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "LabelEntityId", "Name", "Priority", "SerialNumber", "TableId", "TaskEstimation", "TaskStatusEntityId" },
                values: new object[,]
                {
                    { new Guid("0ca148ae-b506-4813-b86e-5e469aa8dc23"), "quis", null, "leverage", 2, 1, new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"), 0, null },
                    { new Guid("1c409359-0e6b-48f9-9ca3-82fed7f8eaa2"), "in", null, "Wooden", 0, 1, new Guid("c47466d9-7713-4482-8034-74941b89dd85"), 0, null },
                    { new Guid("24bcdbd7-d610-41ba-a2aa-9a338958ad77"), "est", null, "Switchable", 0, 0, new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"), 2, null },
                    { new Guid("2a6c5a7b-f03f-467f-bda5-7054ee632485"), "nihil", null, "Berkshire", 3, 1, new Guid("94407c38-647c-406c-87ef-ee26d3e73268"), 1, null },
                    { new Guid("32564cd2-abf5-4b2f-a442-50c15e29bc35"), "qui", null, "Stream", 3, 0, new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"), 0, null },
                    { new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"), "tempora", null, "Buckinghamshire", 0, 0, new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"), 2, null },
                    { new Guid("8ee37a2b-9ed6-4baa-bf30-1be8e874b19d"), "eos", null, "Mexican Peso", 3, 0, new Guid("94407c38-647c-406c-87ef-ee26d3e73268"), 1, null },
                    { new Guid("9a542b84-5341-49d5-8645-d3674d3cc4a1"), "illo", null, "compress", 0, 0, new Guid("9374db0e-1385-4a61-99f3-1bbdd2694870"), 1, null },
                    { new Guid("a07850df-a6af-475f-a1f1-38f88cff3c3f"), "dolorum", null, "Operations", 1, 0, new Guid("985c33c0-3639-4eb2-8865-8f91f23b013c"), 1, null },
                    { new Guid("af4c09d3-68b0-429f-b39d-dd0f5ecc9e6f"), "sequi", null, "Money Market Account", 0, 0, new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"), 1, null },
                    { new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"), "voluptate", null, "Gorgeous Concrete Computer", 0, 1, new Guid("c47466d9-7713-4482-8034-74941b89dd85"), 1, null },
                    { new Guid("d270faed-aab1-455f-b5c4-f9263668b78e"), "rerum", null, "Diverse", 3, 0, new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"), 2, null },
                    { new Guid("d7980152-5d5c-42cb-b838-fd0c4e2b9e02"), "accusamus", null, "Executive", 3, 0, new Guid("8a0759c4-1e13-4821-bc0c-d2fd275381aa"), 2, null },
                    { new Guid("e4d5f8e3-232b-47e0-846a-4cd5cbae9ff0"), "distinctio", null, "Papua New Guinea", 1, 1, new Guid("bd0e27f2-cc29-47bf-83ec-f97e54666938"), 0, null },
                    { new Guid("e91c7efd-ac30-4747-8900-bca20b6d2ed9"), "possimus", null, "Illinois", 0, 0, new Guid("de2b4481-2905-4e2d-b3c6-9e75c4551606"), 0, null },
                    { new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"), "qui", null, "support", 0, 0, new Guid("758c83fe-bbc9-4625-8505-f85dacce0a29"), 0, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("63c11e29-2e11-422e-87dd-60487978a59e"), "Irwin_Hartmann58@gmail.com", "Caden", "Moen" },
                    { new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93"), "Quinten.Crooks@yahoo.com", "Rogers", "Zulauf" },
                    { new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1"), "Marvin.Schaefer@hotmail.com", "Kacey", "Nienow" },
                    { new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"), "Selena93@hotmail.com", "Rogers", "Schuppe" }
                });

            migrationBuilder.InsertData(
                table: "UserBoards",
                columns: new[] { "BoardId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93") },
                    { new Guid("1f9050e0-c42a-44c2-bd95-15cdbdc66235"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1") },
                    { new Guid("787a52e9-7040-4ca8-811a-6d313900e845"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2") },
                    { new Guid("e1299cc7-b81f-4634-87d7-19c3f84f8aa9"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId", "Role" },
                values: new object[,]
                {
                    { new Guid("445638aa-00f1-4e25-bfaf-0f963bc3d1f8"), new Guid("7d3ff7ce-2e90-4e07-ab77-eb9955a9ee93"), 2 },
                    { new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"), new Guid("9af36fdf-6bd4-4d63-9b00-265ac05bb9c1"), 2 },
                    { new Guid("cce3ee84-59ff-4afe-8fb2-dfc315bf825c"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"), 0 },
                    { new Guid("ef307ef9-7a38-49e9-8f9f-a26af2bc03b7"), new Guid("ad7c707f-61c9-43ba-af9f-10ee527230d2"), 2 }
                });
        }
    }
}
