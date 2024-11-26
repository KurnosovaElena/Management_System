using Bogus;
using DAL.Entities;
using DAL.Enums;
using System.Collections.Generic;

namespace DAL.Context;

public class DataGenerator
{
    public static readonly List<BoardEntity> Boards = [];
    public static readonly List<TaskStatusEntity> TaskStatus = [];
    public static readonly List<TaskEntity> Tasks = [];
    public static readonly List<UserBoardEntity> UserBoards = [];
    public static readonly List<SubtaskEntity> Subtasks = [];
    public static readonly List<UserTaskEntity> UserTasks = [];
    public static readonly List<UserEntity> Users = [];
    public static readonly List<LabelEntity> Labels = [];

    public const int NumberOfBoards = 2;
    public const int NumberOfTasks = 2;

    public static void Init()
    {
        GenerateBogusBoardsData();
        GenerateBogusLabelsData();
        GenerateBogusUsersData();
        GenerateUserBoardsData();
        GenerateBogusUserTasksData();
    }

    private static void GenerateBogusBoardsData()
    {
        var boardGenerator = GetBoardFaker();
        var generatedBoards = boardGenerator.Generate(NumberOfBoards);
        Boards.AddRange(generatedBoards);
    }

    private static void GenerateBogusUsersData()
    {
        var userGenerator = GetUserFaker();
        var generatedUsers = userGenerator.Generate(NumberOfBoards);
        Users.AddRange(generatedUsers);
    }

    private static void GenerateBogusLabelsData()
    {
        var labelGenerator = GetLabelFaker();
        var generatedLabels = labelGenerator.Generate(NumberOfBoards);
        Labels.AddRange(generatedLabels);
    }

    private static List<TaskStatusEntity> GetBogusStatusData(Guid boardId)
    {
        var statusGenerator = GetTableFaker(boardId);
        var generatedStatus = statusGenerator.Generate(NumberOfBoards);
        TaskStatus.AddRange(generatedStatus);
        return generatedStatus;
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

    private static void GenerateUserBoardsData()
    {
        var userBoardsGenerator = GetUserBoardsFaker();
        var generatedUserBoards = userBoardsGenerator.Generate(NumberOfBoards);
        UserBoards.AddRange(generatedUserBoards);
    }

    private static void GenerateBogusUserTasksData()
    {
        var userTasksGenerator = GetUserTasksFaker();
        var generatedUserTasks = userTasksGenerator.Generate(NumberOfTasks);
        UserTasks.AddRange(generatedUserTasks);
    }

    private static Faker<BoardEntity> GetBoardFaker() =>
        new Faker<BoardEntity>()
        .RuleFor(b => b.Id, _ => Guid.NewGuid())
        .RuleFor(b => b.Name, f => f.Name.FirstName())
        .RuleFor(b => b.Description, f => f.Lorem.Word())
        .RuleFor(b => b.TaskStatus, (_, e) =>
        {
            GetBogusStatusData(e.Id);
            return [];
        });

    private static Faker<TaskStatusEntity> GetTableFaker(Guid boardId)
    {
        var status = new[] { "In Progress", "In Review", "Done", "Backlog" };

        return new Faker<TaskStatusEntity>()
            .RuleFor(t => t.Id, _ => Guid.NewGuid())
            .RuleFor(t => t.Name, f => f.PickRandomParam(status))
            .RuleFor(t => t.BoardId, _ => boardId)
            .RuleFor(t => t.Tasks, (_, e) =>
            {
                GetBogusTasksData(e.Id);
                return [];
            });
    }

    private static Faker<UserEntity> GetUserFaker() =>
    new Faker<UserEntity>()
    .RuleFor(b => b.Id, _ => Guid.NewGuid())
    .RuleFor(b => b.FirstName, f => f.Name.FirstName())
    .RuleFor(b => b.LastName, f => f.Name.LastName())
    .RuleFor(b => b.Email, f => f.Internet.Email());

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
               GetBogusSubtasksData(e.Id);
               return [];
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