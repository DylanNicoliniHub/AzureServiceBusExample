using MatterManager.Interfaces.Entities;

namespace MatterManager.Interfaces.ApplicationServices
{
    public interface IMatterApplicationService
    {
        void Process(string clientName, IMatter matter); 
    }
}