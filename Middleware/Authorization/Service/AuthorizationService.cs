using Authorization.Entity;
using Authorization.Repository;
using Authorization.Service.Extenciones;
using MongoDB.Driver;

namespace Authorization.Service
{
    public class AuthorizationService :IAuthorizationService
    {
        private readonly IAuthorizationRepository repository;
        private readonly ILogger<AuthorizationService> logger;
        public AuthorizationService(IAuthorizationRepository repository) => this.repository = repository;

        public LoginResponse Logine(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
                if (repository.Logine(request.UserName, request.Password))
                    response.Success($"Bienvenido {request.UserName}");
                else
                    response.Fail($"Usuario y/o contraseña incorrecta");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
            return response;
        }
    }
}
