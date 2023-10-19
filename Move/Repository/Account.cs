using Move.Dataleryer;
using Move.Model;

namespace Move.Repository
{
    public class Account  :IAccount
    {
        private readonly KinoDbContext _slup;

        public Account(KinoDbContext slup)
        {
            _slup = slup;
        }
        public async Task<bool> LogInAsync(string email, string password)
        {
            var res = await _slup.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
            if (res == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> SignUpAsync(User user)
        {
            if (user == null)
            {
                return false;
            }
            await _slup.AddAsync(user);
            _slup.SaveChanges();
            return true;

        }
    }
}
