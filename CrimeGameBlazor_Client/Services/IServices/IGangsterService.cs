using CrimeGameBlazor_DataAccess;

namespace CrimeGameBlazor_Client.Services.IServices
{
    public interface IGangsterService
    {
        public Task<bool> Create(string Name);
        public Task<Gangster?> Get();
    }
}
