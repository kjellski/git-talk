using System;

namespace GitTalk
{
    public class Authentication
    {
        public string ID { get; set; }

        public string Username { get; set; }

        public string Token { get; set; }

        public string[] Claims { get; set; }
    }
}
