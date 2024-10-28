namespace ManagementSystem.Entities
{
    public class Board
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public IEnumerable<Table> Tables { get; set; } = [];
        public IEnumerable<UserBoard> UserBoards { get; set; } = [];
    }
}
