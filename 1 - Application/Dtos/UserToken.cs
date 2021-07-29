using System;

namespace Task.Application.Dtos
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
