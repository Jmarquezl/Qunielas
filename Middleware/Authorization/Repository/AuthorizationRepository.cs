using Authorization.Repository.Collections;
using MongoDB.Driver;

namespace Authorization.Repository
{
    public class AuthorizationRepository : IAuthorizationRepository
    {
        private readonly ICustomMongoClient customClient;
        private readonly ILogger<AuthorizationRepository> logger;
        private const string USUARIO = "Usuario";
        public AuthorizationRepository(ICustomMongoClient customClient, ILogger<AuthorizationRepository> logger)
        {
            this.customClient = customClient;
            this.logger = logger;
        }

        public bool Logine(string user, string password)
        {
            logger.LogInformation("Inicio de la consulta de usuario.");
            try
            {
                return customClient.DataBase.GetCollection<User>(USUARIO).Find(u => u.Usuario.Equals(user) && u.Password.Equals(password)).Any();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
            return false;
        }
    }
}
