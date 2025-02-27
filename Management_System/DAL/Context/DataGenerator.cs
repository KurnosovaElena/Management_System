using Bogus;
using DAL.Entities;
using DAL.Enums;

namespace DAL.Context;

public static class DataGenerator
{
    public static readonly List<BoardEntity> Boards = [];
    public static readonly List<TaskStatusEntity> TaskStatus = [];
    public static readonly List<TaskEntity> Tasks = [];
    public static readonly List<UserBoardEntity> UserBoards = [];
    public static readonly List<SubtaskEntity> Subtasks = [];
    public static readonly List<UserTaskEntity> UserTasks = [];
    public static readonly List<LabelEntity> Labels = [];

    public const int NumberOfBoards = 2;
    public const int NumberOfTasks = 2;

    public static void Init()
    {
        GenerateBogusBoardsData();
        GenerateBogusLabelsData();
        GenerateUserBoardsData();
        GenerateBogusUserTasksData();
    }

    private static void GenerateBogusBoardsData()
    {
        var boardGenerator = GetBoardFaker();
        var generatedBoards = boardGenerator.Generate(NumberOfBoards);
        Boards.AddRange(generatedBoards);
    }

    private static void GenerateBogusLabelsData()
    {
        var labelGenerator = GetLabelFaker();
        var generatedLabels = labelGenerator.Generate(NumberOfBoards);
        Labels.AddRange(generatedLabels);
    }

    private static void GenerateBogusStatusData(Guid boardId)
    {
        var statusGenerator = GetTaskStatusFaker(boardId);
        var generatedStatus = statusGenerator.Generate(NumberOfBoards);
        TaskStatus.AddRange(generatedStatus);
    }

    private static void GenerateBogusSubtasksData(Guid taskId)
    {
        var subtasksGenerator = GetSubtasksFaker(taskId);
        var generatedSubtasks = subtasksGenerator.Generate(NumberOfTasks);
        Subtasks.AddRange(generatedSubtasks);
    }

    private static void GenerateBogusTasksData(Guid userId)
    {
        var tasksGenerator = GetTasksFaker(userId);
        var generatedTasks = tasksGenerator.Generate(NumberOfTasks);
        Tasks.AddRange(generatedTasks);
    }

    private static void GenerateUserBoardsData()
    {
        var userBoardsGenerator = GetUserBoardsFaker();
        var generatedUserBoards = userBoardsGenerator.Generate(NumberOfBoards)
            .GroupBy(ub => new { ub.UserId, ub.BoardId })
            .Select(ub => ub.FirstOrDefault())
            .ToList();

        UserBoards.AddRange(generatedUserBoards);
    }

    private static void GenerateBogusUserTasksData()
    {
        var userTasksGenerator = GetUserTasksFaker();
        var generatedUserTasks = userTasksGenerator.Generate(NumberOfTasks)
            .GroupBy(ut => new { ut.UserId, ut.TaskId })
            .Select(ut => ut.FirstOrDefault())
            .ToList();

        UserTasks.AddRange(generatedUserTasks);
    }

    private static Faker<BoardEntity> GetBoardFaker() =>
        new Faker<BoardEntity>()
        .RuleFor(b => b.Id, _ => Guid.NewGuid())
        .RuleFor(b => b.Name, f => f.Name.FirstName())
        .RuleFor(b => b.Description, f => f.Lorem.Word())
        .RuleFor(b => b.TaskStatus, (_, e) =>
        {
            GenerateBogusStatusData(e.Id);
            return [];
        });

    private static Faker<TaskStatusEntity> GetTaskStatusFaker(Guid boardId)
    {
        var status = new[] { "In Progress", "In Review", "Done", "Backlog" };

        return new Faker<TaskStatusEntity>()
            .RuleFor(t => t.Id, _ => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.PickRandomParam(status))
            .RuleFor(t => t.Description, f => f.Lorem.Word())
            .RuleFor(t => t.BoardId, _ => boardId)
            .RuleFor(t => t.Tasks, (_, e) =>
            {
                GenerateBogusTasksData(e.Id);
                return [];
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
               GenerateBogusSubtasksData(e.Id);
               return [];
           });
    }

    private static Faker<UserBoardEntity> GetUserBoardsFaker()
    {
        return new Faker<UserBoardEntity>()
            .RuleFor(ub => ub.BoardId, _ => _.PickRandom(Boards).Id);
    }

    private static Faker<UserTaskEntity> GetUserTasksFaker()
    {
        return new Faker<UserTaskEntity>()
            .RuleFor(ub => ub.TaskId, _ => _.PickRandom(Tasks).Id)
            .RuleFor(ub => ub.Role, f => f.PickRandom(Enum.GetValues(typeof(TaskRole)).Cast<TaskRole>()));
    }
}