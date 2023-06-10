using Mondy.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Mondy.BusinessLogic.Service
{
    public class UserService : Service
	{
        public ServiceResponse<User> GetById(int id)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.Id == id));
        }

        public ServiceResponse<User> GetByEmail(string email)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.Email == email));
        }

        public ServiceResponse<User> Edit(User user)
        {
            DbContext.Entry(user).State = EntityState.Modified;
            DbContext.SaveChanges();
            return Success(user);
        }

        public ServiceResponse<User> Delete(User user)
        {
            DbContext.Entry(user).State = EntityState.Deleted;
            DbContext.SaveChanges();
            return Success(user);
        }

        public ServiceResponse<List<User>> GetAll()
        {
            return Success(DbContext.Users.ToList());
        }
    }
}
