using AIPrompts.Models;

namespace AIPrompts
{
    internal class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal int InsertPromptAndGetID(ImagePrompt prompt)
        {
            throw new NotImplementedException();
        }
    }
}