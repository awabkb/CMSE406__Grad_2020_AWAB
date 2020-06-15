
using CMSE406_OutlineSystem.Models;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(string userId, string password);


    }
}