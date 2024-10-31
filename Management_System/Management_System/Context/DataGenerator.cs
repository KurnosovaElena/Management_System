using Bogus;
using ManagementSystem.Entities;
using ManagementSystem.Enums;
using System.Collections.Generic;

namespace ManagementSystem.Context
{
    public class DataGenerator
    {
        public static readonly List<BoardEntity> Boards = new();
        public static readonly List<TableEntity> Tables = new();
        public static readonly List<TaskEntity> Tasks = new();
        public static readonly List<UserBoardEntity> UserBoards = new();
        public static readonly List<SubtaskEntity> Subtasks = new();
        public static readonly List<UserTaskEntity> UserTasks = new();
        public static readonly List<UserEntity> Users = new();
        public static readonly List<LabelEntity> Labels = new();

        public const int NumberOfBoards = 2;
        public const int NumberOfTasks = 2;

        public static void Init()
        {
            GetBogusBoardsData();
            GetLabelFaker();
            GetUserBoardsData();
            GetBogusUserTasksData();
        }
        private static void GetBogusBoardsData()
        {
            var boardGenerator = GetBoardFaker();
            var generatedBoards = boardGenerator.Generate(NumberOfBoards);
            Boards.AddRange(generatedBoards);
        }
        private static void GetBogusLabelsData()
        {
            var labelGenerator = GetLabelFaker();
            var generatedLabels = labelGenerator.Generate(NumberOfBoards);
            Labels.AddRange(generatedLabels);
        }

        private static List<TableEntity> GetBogusTablesData(Guid boardId)
        {
            var tableGenerator = GetTableFaker(boardId);
            var generatedTables = tableGenerator.Generate(NumberOfBoards);
            Tables.AddRange(generatedTables);
            return generatedTables;
        }

        private static List<SubtaskEntity> GetBogusSubtasksData(Guid taskId)
        {
            var subtasksGenerator = GetSubtasksFaker(taskId);
            var generatedSubtasks = subtasksGenerator.Generate(NumberOfTasks);
            Subtasks.AddRange(generatedSubtasks);
            return generatedSubtasks;
        }

        private static List<TaskEntity> GetBogusTasksData(Guid userId)
        {
            var tasksGenerator = GetTasksFaker(userId);
            var generatedTasks = tasksGenerator.Generate(NumberOfTasks);
            Tasks.AddRange(generatedTasks);
            return generatedTasks;
        }

        private static List<UserBoardEntity> GetUserBoardsData()
        {
            var userBoardsGenerator = GetUserBoardsFaker();
            var generatedUserBoards = userBoardsGenerator.Generate(NumberOfBoards);
            UserBoards.AddRange(generatedUserBoards);
            return generatedUserBoards;
        }

        private static List<UserTaskEntity> GetBogusUserTasksData()
        {
            var userTasksGenerator = GetUserTasksFaker();
            var generatedUserTasks = userTasksGenerator.Generate(NumberOfTasks);
            UserTasks.AddRange(generatedUserTasks);
            return generatedUserTasks;
        }

        private static Faker<BoardEntity> GetBoardFaker() =>
            new Faker<BoardEntity>()
            .RuleFor(b => b.Id, _ => Guid.NewGuid())
            .RuleFor(b => b.Name, f => f.Name.FirstName())
            .RuleFor(b => b.Description, f => f.Lorem.Word())
            .RuleFor(b => b.Tables, (_, e) =>
            {
                return GetBogusTablesData(e.Id);
            });
        private static Faker<TableEntity> GetTableFaker(Guid boardId)
        {
            var status = new[] { "In Progress", "In Review", "Done", "Backlog" };

            return new Faker<TableEntity>()
                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                .RuleFor(t => t.Name, f => f.PickRandomParam(status))
                .RuleFor(t => t.BoardId, _ => boardId)
                .RuleFor(t => t.Tasks, (_, e) =>
                {
                    return GetBogusTasksData(e.Id);
                });
        }

        private static Faker<LabelEntity> GetLabelFaker()
        {
            return new Faker<LabelEntity>()
                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                .RuleFor(t => t.Name, f => f.Random.Word())
                .RuleFor(t => t.Description, f => f.Lorem.Word());
        }

        private static Faker<SubtaskEntity> GetSubtasksFaker(Guid taskId)
        {
            return new Faker<SubtaskEntity>()
                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                .RuleFor(t => t.Name, f => f.Random.Word())
                .RuleFor(t => t.Description, f => f.Lorem.Word())
                .RuleFor(t => t.TaskId, _ => taskId);
        }

        private static Faker<TaskEntity> GetTasksFaker(Guid tableId)
        {
            return new Faker<TaskEntity>()
               .RuleFor(r => r.Id, _ => Guid.NewGuid())
               .RuleFor(r => r.SerialNumber, f => f.Random.Number())
               .RuleFor(r => r.Name, f => f.Random.Word())
               .RuleFor(r => r.Description, f => f.Lorem.Word())
               .RuleFor(r => r.Priority, f => f.PickRandom(Enum.GetValues(typeof(TaskPriority)).Cast<TaskPriority>()))
               .RuleFor(r => r.TaskEstimation, f => f.PickRandom(Enum.GetValues(typeof(TaskEstimation)).Cast<TaskEstimation>()))
               .RuleFor(t => t.TableId, _ => tableId)
               .RuleFor(t => t.Subtasks, (_, e) =>
               {
                   return GetBogusSubtasksData(e.Id);
               });
        }

        private static Faker<UserBoardEntity> GetUserBoardsFaker()
        {
            return new Faker<UserBoardEntity>()
                .RuleFor(ub => ub.UserId, _ => _.PickRandom(Users).Id)
                .RuleFor(ub => ub.BoardId, _ => _.PickRandom(Boards).Id);
        }

        private static Faker<UserTaskEntity> GetUserTasksFaker()
        {
            return new Faker<UserTaskEntity>()
                .RuleFor(ub => ub.UserId, _ => _.PickRandom(Users).Id)
                .RuleFor(ub => ub.TaskId, _ => _.PickRandom(Tasks).Id)
                .RuleFor(ub => ub.Role, f => f.PickRandom(Enum.GetValues(typeof(TaskRole)).Cast<TaskRole>()));
        }
    }
}
