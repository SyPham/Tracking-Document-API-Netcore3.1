using API.Models;
using API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service.Interface
{
    public interface IUserService : ICommonService<UserAccount, int>
    {
        void Save();
    }
}
