
namespace SampSharp.YSF.Events
{
    public class RemoteRCONPacketEventArgs
    {
        public RemoteRCONPacketEventArgs(string ipaddress, int port, string password, int success, string command)
        {
            IPAddress = ipaddress;
            Port = port;
            Password = password;
            Success = success;
            Command = command;
        }

        public string IPAddress { get; }
        public int Port { get; }
        public string Password { get; }
        public int Success { get; }
        public string Command { get; }
    }
}
