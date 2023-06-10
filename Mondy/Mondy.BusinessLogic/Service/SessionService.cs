using Mondy.Domain.Entities;
using System.Data.Entity;
using System.Linq;

namespace Mondy.BusinessLogic.Service
{
	public class SessionService : Service
    {
        public ServiceResponse<Session> GetByToken(string token)
        {
            return Success(DbContext.Sessions.FirstOrDefault(x => x.Token == token));
        }
    }
}
