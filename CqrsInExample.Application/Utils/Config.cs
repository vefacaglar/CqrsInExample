namespace CqrsInExample.Application.Utils
{
    public sealed class Config
    {
        public int NumberOfDatabaseRetries { get; }

        public Config(int numberOfDatabaseRetries)
        {
            NumberOfDatabaseRetries = numberOfDatabaseRetries;
        }
    }
}
