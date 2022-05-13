using System;

namespace IntegrifyCsharp.Authentication
{
    [Serializable]
    public class JwtAuthResponse
    {
        public string token {get; init;}

        public string user_name {get; init;}

        public int expires_in {get; init;}
        
    }
}