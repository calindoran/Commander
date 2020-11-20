using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands(); // Updated from GetAppCommands
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

    }
}