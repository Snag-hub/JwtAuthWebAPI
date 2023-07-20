namespace JwtAuthWebAPI.Interface
{
    public interface IUserAuth
    {
        // this is an interface for login it take username and password and return a token with department and role with expiration time
        public void Login(string username, string password);

    }
}
