using Authorization.Entity;

namespace Authorization.Service
{
    public interface IAuthorizationService
    {
        LoginResponse Logine(LoginRequest request);
    }
}
