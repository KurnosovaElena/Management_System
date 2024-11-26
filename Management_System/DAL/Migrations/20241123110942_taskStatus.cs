using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class taskStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tables_TableEntityId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("189a4c66-bc77-4cf4-b6fd-ea63cb6b778c"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("e573dd1d-5906-416f-bf03-1fce295a0446"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("e7a27f55-332c-409b-9105-fef80f62ffd5"));

            migrationBuilder.DeleteData(
                table: "Labels",
                keyColumn: "Id",
                keyValue: new Guid("fbf4948c-7b94-4c32-afac-3c291fc65bb1"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("0d68b57d-7d22-45ef-8481-cd9c991d17e5"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("1fe86f6c-1038-41a8-9015-75ec7c009e32"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("263d98c5-bc95-4634-98ae-8612ea569887"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("2643970f-193c-49a9-9ea2-b092f837eb5c"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("3c171c44-42cf-402c-bf40-c69fee0ca58c"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("447d6c24-fee2-47b7-9c8a-f21062328e21"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("448c0973-c78c-4abe-b734-a5e8ce0b3f90"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("45d1af29-ed21-4682-9f48-4303bd13071f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4e2fd5b0-57ed-465d-b40c-3b74fa64bfb2"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("4e331a50-2eeb-4688-b64d-4013b1994b03"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("52a0bfaf-a256-4419-9af8-75a111723696"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("611847de-3ee1-46f5-9781-e4654f5d12ac"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("61c48591-f829-40f3-866e-6c3920e8b6ae"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("75ffdcc5-0e59-4fbf-a65e-23c952300190"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7db61a62-c7cb-495e-ab26-43d0023030ad"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("7f316050-c441-4176-866c-39d57c244751"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("84ecb298-a61c-4737-85cc-544077909ba5"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("880bb697-53ca-4fd7-92c7-ae1449689d02"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8a2e5c1e-6eb8-4f14-8cd8-a2d956d066ff"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("8c07948c-891a-4c5d-ab2c-05744091ce74"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("92ef39f7-91f6-4aa6-a2f2-72b3609a88e3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("948be6d8-351c-495b-9f3b-0e90de7dcd66"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("9e4f8927-4cd3-46e7-9236-b9ae98755223"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("a64e1389-7c65-478a-b402-9c81777e3bcd"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("bd796399-4b26-4ec3-ac86-e25e087721e3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("c825f73f-d471-46cd-b20e-66488ea211ff"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("d8603fb9-a559-4b1a-bdab-31283ecae7e3"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("dca72ab5-39bc-466a-a37f-62ac0036e38f"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("ea0a1f5a-e82f-43e6-8853-d043881e045b"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f236533b-2e5b-4392-a69b-2337eff71601"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f5272147-c44d-418c-8bd9-2ae5a1a3c1f7"));

            migrationBuilder.DeleteData(
                table: "Subtasks",
                keyColumn: "Id",
                keyValue: new Guid("f978c751-c274-4ed1-a72d-418ae057d2ab"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("26947500-da97-44eb-9109-89e48d9bc8d8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("560117de-5950-4da3-8037-5008c8ba099c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("62e452f8-94fb-4206-85da-b19107d8deef"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("677bb241-56a9-4a56-9922-37b2f1479e54"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ab113580-3570-437e-992e-c5b045190d96"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f"));

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("06112724-8dd5-4bda-b90b-ede665639363"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("06112724-8dd5-4bda-b90b-ede665639363"), new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") });

            migrationBuilder.DeleteData(
                table: "UserBoards",
                keyColumns: new[] { "BoardId", "UserId" },
                keyValues: new object[] { new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"), new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"), new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("4d207694-349a-4eba-bf81-eb3869282974"), new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") });

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("06112724-8dd5-4bda-b90b-ede665639363"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"));

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4d207694-349a-4eba-bf81-eb3869282974"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836"));

            migrationBuilder.RenameColumn(
                name: "TableEntityId",
                table: "Tasks",
                newName: "TaskStatusEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TableEntityId",
                table: "Tasks",
                newName: "IX_Tasks_TaskStatusEntityId");

            migrationBuilder.CreateTable(
                name: "TaskStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    BoardId = table.Column<Guid>(type: "uuid", nullable: false),
                    BoardEntityId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskStatus_Boards_BoardEntityId",
                        column: x => x.BoardEntityId,
                        principalTable: "Boards",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatus_BoardEntityId",
                table: "TaskStatus",
                column: "BoardEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskStatus_TaskStatusEntityId",
                table: "Tasks",
                column: "TaskStatusEntityId",
                principalTable: "TaskStatus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskStatus_TaskStatusEntityId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskStatus");

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

            migrationBuilder.RenameColumn(
                name: "TaskStatusEntityId",
                table: "Tasks",
                newName: "TableEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TaskStatusEntityId",
                table: "Tasks",
                newName: "IX_Tasks_TableEntityId");

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BoardEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    BoardId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_Boards_BoardEntityId",
                        column: x => x.BoardEntityId,
                        principalTable: "Boards",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("06112724-8dd5-4bda-b90b-ede665639363"), "natus", "Edyth" },
                    { new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"), "nemo", "Jettie" },
                    { new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"), "similique", "Nils" },
                    { new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"), "unde", "Gail" }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("189a4c66-bc77-4cf4-b6fd-ea63cb6b778c"), "enim", "Marketing" },
                    { new Guid("e573dd1d-5906-416f-bf03-1fce295a0446"), "eum", "empowering" },
                    { new Guid("e7a27f55-332c-409b-9105-fef80f62ffd5"), "numquam", "International" },
                    { new Guid("fbf4948c-7b94-4c32-afac-3c291fc65bb1"), "ex", "plug-and-play" }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "Id", "Description", "Name", "TaskEntityId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("0d68b57d-7d22-45ef-8481-cd9c991d17e5"), "ut", "parsing", null, new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300") },
                    { new Guid("1fe86f6c-1038-41a8-9015-75ec7c009e32"), "explicabo", "California", null, new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b") },
                    { new Guid("263d98c5-bc95-4634-98ae-8612ea569887"), "ut", "Strategist", null, new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603") },
                    { new Guid("2643970f-193c-49a9-9ea2-b092f837eb5c"), "minus", "Soft", null, new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0") },
                    { new Guid("3c171c44-42cf-402c-bf40-c69fee0ca58c"), "odio", "Prairie", null, new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f") },
                    { new Guid("447d6c24-fee2-47b7-9c8a-f21062328e21"), "ea", "Optimization", null, new Guid("26947500-da97-44eb-9109-89e48d9bc8d8") },
                    { new Guid("448c0973-c78c-4abe-b734-a5e8ce0b3f90"), "voluptas", "Handcrafted Metal Fish", null, new Guid("4d207694-349a-4eba-bf81-eb3869282974") },
                    { new Guid("45d1af29-ed21-4682-9f48-4303bd13071f"), "fuga", "HDD", null, new Guid("677bb241-56a9-4a56-9922-37b2f1479e54") },
                    { new Guid("4e2fd5b0-57ed-465d-b40c-3b74fa64bfb2"), "laboriosam", "Human", null, new Guid("ab113580-3570-437e-992e-c5b045190d96") },
                    { new Guid("4e331a50-2eeb-4688-b64d-4013b1994b03"), "nam", "CSS", null, new Guid("62e452f8-94fb-4206-85da-b19107d8deef") },
                    { new Guid("52a0bfaf-a256-4419-9af8-75a111723696"), "et", "Louisiana", null, new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87") },
                    { new Guid("611847de-3ee1-46f5-9781-e4654f5d12ac"), "rerum", "payment", null, new Guid("4d207694-349a-4eba-bf81-eb3869282974") },
                    { new Guid("61c48591-f829-40f3-866e-6c3920e8b6ae"), "sed", "Lari", null, new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be") },
                    { new Guid("75ffdcc5-0e59-4fbf-a65e-23c952300190"), "mollitia", "Fantastic Soft Chicken", null, new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87") },
                    { new Guid("7db61a62-c7cb-495e-ab26-43d0023030ad"), "repudiandae", "Personal Loan Account", null, new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858") },
                    { new Guid("7f316050-c441-4176-866c-39d57c244751"), "iste", "orchestrate", null, new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa") },
                    { new Guid("84ecb298-a61c-4737-85cc-544077909ba5"), "nulla", "exploit", null, new Guid("677bb241-56a9-4a56-9922-37b2f1479e54") },
                    { new Guid("880bb697-53ca-4fd7-92c7-ae1449689d02"), "quo", "platforms", null, new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be") },
                    { new Guid("8a2e5c1e-6eb8-4f14-8cd8-a2d956d066ff"), "maiores", "innovate", null, new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603") },
                    { new Guid("8c07948c-891a-4c5d-ab2c-05744091ce74"), "enim", "Wooden", null, new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50") },
                    { new Guid("92ef39f7-91f6-4aa6-a2f2-72b3609a88e3"), "et", "bypass", null, new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300") },
                    { new Guid("948be6d8-351c-495b-9f3b-0e90de7dcd66"), "placeat", "Open-architected", null, new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa") },
                    { new Guid("9e4f8927-4cd3-46e7-9236-b9ae98755223"), "porro", "Won", null, new Guid("26947500-da97-44eb-9109-89e48d9bc8d8") },
                    { new Guid("a64e1389-7c65-478a-b402-9c81777e3bcd"), "et", "Computers & Baby", null, new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f") },
                    { new Guid("bd796399-4b26-4ec3-ac86-e25e087721e3"), "voluptas", "Toys & Electronics", null, new Guid("62e452f8-94fb-4206-85da-b19107d8deef") },
                    { new Guid("c825f73f-d471-46cd-b20e-66488ea211ff"), "nobis", "Focused", null, new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858") },
                    { new Guid("d8603fb9-a559-4b1a-bdab-31283ecae7e3"), "unde", "Zloty", null, new Guid("ab113580-3570-437e-992e-c5b045190d96") },
                    { new Guid("dca72ab5-39bc-466a-a37f-62ac0036e38f"), "placeat", "morph", null, new Guid("560117de-5950-4da3-8037-5008c8ba099c") },
                    { new Guid("ea0a1f5a-e82f-43e6-8853-d043881e045b"), "et", "evolve", null, new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50") },
                    { new Guid("f236533b-2e5b-4392-a69b-2337eff71601"), "vitae", "Handcrafted", null, new Guid("560117de-5950-4da3-8037-5008c8ba099c") },
                    { new Guid("f5272147-c44d-418c-8bd9-2ae5a1a3c1f7"), "dolorem", "Dynamic", null, new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b") },
                    { new Guid("f978c751-c274-4ed1-a72d-418ae057d2ab"), "rerum", "bricks-and-clicks", null, new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "BoardEntityId", "BoardId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"), null, new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"), "", "In Progress" },
                    { new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"), null, new Guid("06112724-8dd5-4bda-b90b-ede665639363"), "", "In Review" },
                    { new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"), null, new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"), "", "In Review" },
                    { new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"), null, new Guid("06112724-8dd5-4bda-b90b-ede665639363"), "", "Backlog" },
                    { new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"), null, new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"), "", "In Review" },
                    { new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"), null, new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"), "", "In Progress" },
                    { new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"), null, new Guid("1ab0c124-f5a3-4ecc-9013-30467a2da072"), "", "Backlog" },
                    { new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"), null, new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"), "", "In Review" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "LabelEntityId", "Name", "Priority", "SerialNumber", "TableEntityId", "TableId", "TaskEstimation" },
                values: new object[,]
                {
                    { new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"), "dicta", null, "JBOD", 3, 1, null, new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"), 1 },
                    { new Guid("26947500-da97-44eb-9109-89e48d9bc8d8"), "dolores", null, "Incredible Steel Computer", 3, 0, null, new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"), 2 },
                    { new Guid("2db9acce-74b1-46d5-8d81-7a06400f0858"), "iure", null, "Identity", 1, 1, null, new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"), 0 },
                    { new Guid("31e4a0da-0c42-4b47-aa2d-d9d652d41a87"), "sed", null, "Profit-focused", 0, 0, null, new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"), 1 },
                    { new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"), "qui", null, "Fantastic Fresh Fish", 0, 1, null, new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"), 2 },
                    { new Guid("490027c4-89ab-4731-bc86-b2bf5d30d300"), "minima", null, "partnerships", 1, 0, null, new Guid("cdbfba5c-3c2b-4bf7-814a-26a0f080d5df"), 0 },
                    { new Guid("4d207694-349a-4eba-bf81-eb3869282974"), "praesentium", null, "Trail", 1, 0, null, new Guid("4ed7a4c6-f551-4512-a61e-7a3a6dffc603"), 1 },
                    { new Guid("560117de-5950-4da3-8037-5008c8ba099c"), "esse", null, "XML", 2, 0, null, new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"), 0 },
                    { new Guid("5bde72a9-4268-49f8-a3d0-8e5baed76603"), "sint", null, "dynamic", 3, 0, null, new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"), 2 },
                    { new Guid("62e452f8-94fb-4206-85da-b19107d8deef"), "vel", null, "payment", 1, 0, null, new Guid("3382d06b-8dc9-4d70-b854-e0fafd1a975a"), 2 },
                    { new Guid("677bb241-56a9-4a56-9922-37b2f1479e54"), "doloremque", null, "turquoise", 3, 0, null, new Guid("610d69b7-1b8a-498f-9f0f-75e5be4b62a4"), 0 },
                    { new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"), "molestias", null, "withdrawal", 2, 1, null, new Guid("2092b757-bd9b-4494-ba09-ee0476b5bb1d"), 0 },
                    { new Guid("8d64bce0-c5b5-4620-b7cd-f3deb3175e50"), "tempora", null, "Small Cotton Bacon", 0, 1, null, new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"), 0 },
                    { new Guid("ab113580-3570-437e-992e-c5b045190d96"), "suscipit", null, "Shoals", 1, 0, null, new Guid("f1a72a66-6b36-4992-be45-9068a4d08b56"), 2 },
                    { new Guid("b1de66b5-bac2-4b5e-9e01-8f68671ff5b0"), "eum", null, "knowledge base", 2, 0, null, new Guid("bab5baf1-463d-408a-b1e5-d7e5b826b9ec"), 2 },
                    { new Guid("f9a59b7f-f59c-4cda-9b1f-a525f399289f"), "consequatur", null, "Solomon Islands Dollar", 1, 1, null, new Guid("f2f32110-68ed-4f27-b104-7b0ef7f19d72"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"), "Cordia.Nicolas@yahoo.com", "Lamar", "Keebler" },
                    { new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41"), "Everette37@yahoo.com", "Delmer", "Botsford" },
                    { new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292"), "Maya.Kuhic@yahoo.com", "Joanie", "Metz" },
                    { new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836"), "Ruthie.Gleichner51@hotmail.com", "Marcelo", "Heidenreich" }
                });

            migrationBuilder.InsertData(
                table: "UserBoards",
                columns: new[] { "BoardId", "UserId" },
                values: new object[,]
                {
                    { new Guid("06112724-8dd5-4bda-b90b-ede665639363"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") },
                    { new Guid("06112724-8dd5-4bda-b90b-ede665639363"), new Guid("cfeafa76-220e-4a7f-b661-e3212fc67836") },
                    { new Guid("85551ab1-caa5-4833-aba4-d0e67384611a"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05") },
                    { new Guid("c1f8279a-eac3-4adb-9c42-3b6a651cbdeb"), new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId", "Role" },
                values: new object[,]
                {
                    { new Guid("069e1e8e-d4a4-428e-95b7-ce148e5b26be"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"), 0 },
                    { new Guid("32792ce1-87c9-455e-bbd5-6624b8157ffa"), new Guid("5a99adf2-f4b6-4a20-8088-fa6e84b0a292"), 1 },
                    { new Guid("4d207694-349a-4eba-bf81-eb3869282974"), new Guid("48e55e1b-0ce1-417c-960e-9ccf2983aa41"), 1 },
                    { new Guid("713c42d6-4a5b-4dc8-b02a-78582d7fdc2b"), new Guid("1674dc41-cdd9-4c84-9e19-ac9cc1327c05"), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tables_BoardEntityId",
                table: "Tables",
                column: "BoardEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tables_TableEntityId",
                table: "Tasks",
                column: "TableEntityId",
                principalTable: "Tables",
                principalColumn: "Id");
        }
    }
}
