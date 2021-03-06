using System.Threading.Tasks;
using ChatServer.Model.ViewModels;

namespace ChatServer.Service.Contract {
    public interface IAuthenticationService {
        Task<string> Authenticate (AuthenticateVM model);
    }
}