using Renci.SshNet;
using static Semainier.Data.DB;
using static Semainier.Data.SshConnection;

namespace Semainier.Data
{
    public class DBService
    {
        public async Task<bool> SetSshClient(string host, string user, string pass)
        {
            SshConnection.host = host;
            SshConnection.user = user;
            SshConnection.pass = pass;
            client = new SshClient(host, user, pass);
            return true;
        }

        public async Task<bool> SetDbConnectionString(string host, string user, string pass, string schema)
        {
            connectionString = new DbConnectionString(host, user, pass, schema);
            return true;
        }

        public async Task<string[]> ExecuteSqlCommandOnDB(string command)
        {
            string MySqlCommand = "mysql -u " + connectionString.user + " " + connectionString.schema + " -h " + connectionString.host + " --password=" + connectionString.pass + " --execute=\"" + command + "\"";
            return client.CreateCommand(MySqlCommand).Execute().Split("\n");
        }

        public async Task<bool> Connect()
        {
            if (!client.IsConnected)
                client.Connect();
            return true;
        }
        public async Task<bool> Disconnect()
        {
            if (client.IsConnected)
                client.Disconnect();
            return true;
        }

    }
}
