using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands(); // Updated from GetAppCommands
        Command GetCommandById(int id);

    }
}