using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RektaManager.Shared;

namespace RektaManager.Server.Data
{
    public class RektaManagerContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public RektaManagerContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}
