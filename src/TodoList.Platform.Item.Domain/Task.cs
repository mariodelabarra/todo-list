using TodoList.Platform.Domain.Entities;

namespace TodoList.Platform.Item.Domain
{
    public class Task : BaseEntity
    {
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
    }
}
