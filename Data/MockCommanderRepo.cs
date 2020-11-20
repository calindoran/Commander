using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{ Id = 0, HowTo = "Code a program", Line = "Sit down at a computer", Platform = "Desk and Computer" },
                new Command{ Id = 1, HowTo = "Test a program", Line = "Download a test enviorment", Platform = "Computer and Internet" },
                new Command{ Id = 2, HowTo = "Make some coffee", Line = "Put coffee in cup", Platform = "Cup and Boiling water" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Code a program", Line = "Sit down at a computer", Platform = "Desk and Computer" };
        }
    }
}