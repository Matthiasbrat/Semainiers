using System.Reflection.Metadata;

namespace Semainier.Data
{
    public class DbConnectionString
    {
        public string? host { get; set; }
        public string? user { get; set; }
        public string? pass { get; set; }
        public string? schema { get; set; }

        public DbConnectionString(string host, string user, string pass, string schema)
        {
            this.host = host;
            this.user = user;
            this.pass = pass;
            this.schema = schema;
        }
    }
}
