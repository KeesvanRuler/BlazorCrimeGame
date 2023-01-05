using CrimeGameBlazor_Models;

namespace CrimeGameBlazor_Client.Services.IServices
{
    public interface IBasicCrimeService
    {
        public Task<BasicCrimeResultDTO> ShootingRange();
        public Task<BasicCrimeResultDTO> RobJuwelryStore();
        public Task<BasicCrimeResultDTO> RobGrandma();
    }
}
