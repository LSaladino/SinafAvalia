namespace sinafavalia.api.data
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string CollectionName { get; set; } = string.Empty;
    }
}