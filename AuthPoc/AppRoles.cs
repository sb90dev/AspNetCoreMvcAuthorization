using System.Security.Claims;

namespace AuthPoc
{
    public static class AppRoles
    {
        public const string Admin = "admin";
        public const string Manager = "manager";

        public static bool IsInAnyRole(this ClaimsPrincipal claimsPrincipal, IEnumerable<string> roles)
            => roles.Any(role => claimsPrincipal.IsInRole(role));
    }

    public static class AuthorizationPolicies
    {
        public const string AdminOrManager = "adminOrManager";
    }
}
