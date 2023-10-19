using Move.Model;

namespace Move.Repository
{
        public interface IAccount
        {
            Task<bool> SignUpAsync(User user);
            Task<bool> LogInAsync(string email, string password);
        }
    
}
