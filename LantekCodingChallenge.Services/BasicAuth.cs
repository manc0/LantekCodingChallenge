using System.Text;

namespace LantekCodingChallenge.Services
{
    public class BasicAuth(string username, string password)
    {
        public string UserName { get; set; } = username;
        public string Password { get; set; } = password;

        public byte[] Bytes => new UTF8Encoding().GetBytes($"{UserName}:{Password}");

        public Action? ValuesChanged;
    }
}
