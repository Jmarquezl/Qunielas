
namespace Authorization.Repository
{
    public interface IAuthorizationRepository
    {
        bool Logine(string user, string password);
    }
}
