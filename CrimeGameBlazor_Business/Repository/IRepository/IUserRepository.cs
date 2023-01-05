using CrimeGameBlazor_DataAccess;
using CrimeGameBlazor_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeGameBlazor_Business.Repository.IRepository
{
    public interface IUserRepository
    {
        public Task<IEnumerable<UserDTO>> GetAll();
        public Task<UserDTO> GetById(string Id);
        public Task<int> DeleteById(string Id);

    }
}
