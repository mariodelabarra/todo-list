using TodoList.Platform.Common.Repository;

namespace TodoList.Platform.Item.Repositories
{
    public interface ITaskRepository : IGenericRepository<Domain.Task>
    {
    }

    public class TaskRepository : GenericRepository<Domain.Task>, ITaskRepository
    {
        public TaskRepository(ItemDbContext context) : base(context)
        {
        }
    }
}
