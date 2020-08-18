using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{ID=0, HowTo="Boil an egg", Line="Boil water", Platform="Pan and kettle"},
                new Command{ID=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife and board"},
                new Command{ID=2, HowTo="Make tea", Line="Get a tea bag", Platform="Kettle and cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ID=0, HowTo="Boil an egg", Line="Boil water", Platform="Pan and kettle"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}