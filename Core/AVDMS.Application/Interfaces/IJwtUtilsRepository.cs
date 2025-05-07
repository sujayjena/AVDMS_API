using AVDMS.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVDMS.Application.Interfaces
{
    public interface IJwtUtilsRepository
    {
        public (string, DateTime) GenerateJwtToken(UsersLoginSessionData parameters);
        Task<UsersLoginSessionData?> ValidateJwtToken(string token);
    }
}
