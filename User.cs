using System.Net;

namespace ServerForGame
{
    public class User
    {
        public string Id { get; set; }
        public IPEndPoint FullInfoIP { get; set; }
        public string Name { get; set; }
    }
}
