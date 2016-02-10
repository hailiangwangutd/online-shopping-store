using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class FormsAuthenticationProvider : IAuthentication
    {
        private readonly EFDbContext context = new EFDbContext();
        public bool Authenticate(string username, string password)
        {
            var result = context.Users.FirstOrDefault(u => u.UserId == username && u.PassWord == password);
            return result != null;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
