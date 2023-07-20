using JwtAuthWebAPI.Interface;

namespace JwtAuthWebAPI.Repository
{
    public class UserRepository : IUserAuth
    {
        private readonly JwtAuthDBContext _context;
        public UserRepository(JwtAuthDBContext context)
        {
            _context = context;
        }
        public void Login(string username, string password)
        {
            // check if user exist in database using query
            var user = _context.UserInfo.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (user == null)
            {
                throw new Exception("Invalid Username or Password");
            }
            // if user exist then generate token



        }
    }
}
