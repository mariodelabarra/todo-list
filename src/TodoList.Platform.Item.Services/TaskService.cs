using TodoList.Platform.Item.Repositories;

namespace TodoList.Platform.Item.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Domain.Task>> GetAll();
    }

    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<Domain.Task>> GetAll()
        {
            var tasks = _taskRepository.GetAll();
            await Task.CompletedTask;
            return tasks;
        }
    }
}
