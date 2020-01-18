namespace OOP._4._Branching.After_ISP
{
    public class NetworkFileStore : FileStore, IConnectable
    {
        public NetworkFileStore(string workingDirectory, string username, string password) : base(workingDirectory) {
            Username = username;
            Password = password;
        }

        public void Connect() {
            // COnnect to network
        }

        public void Disconnect() {
            // DIsconnect from network
        }

        public string Username { get; private set; }

        public string Password { get; private set; }
    }
}
