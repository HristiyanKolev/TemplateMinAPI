using TemplateMinAPI.Models;

namespace TemplateMinAPI.Data
{
    public class CommandRepo : ICommandRepo
    {
        public Task CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Command>> GetAllCommands()
        {
            throw new NotImplementedException();
        }

        public Task<Command?> GetCommandById(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}