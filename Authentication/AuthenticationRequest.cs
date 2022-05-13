using System;

namespace IntegrifyCsharp
{
    [Serializable]
    public class AuthenticationRequest
    {
        public string UserName {get; init;}
        public string Password {get; init;}
    }
}