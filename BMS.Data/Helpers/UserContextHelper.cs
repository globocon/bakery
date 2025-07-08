using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Helpers
{
    public static class UserContextHelper
    {
        /// <summary>
        /// Gets the current user ID from the provided IHttpContextAccessor.
        /// </summary>
        public static string? GetCurrentUserId(IHttpContextAccessor httpContextAccessor)
        {
            var user = httpContextAccessor?.HttpContext?.User;
            if (user == null || !user.Identity?.IsAuthenticated == true)
                return null;

            // Try to get the NameIdentifier claim (standard for user id)
            return user.FindFirst(ClaimTypes.Sid)?.Value;
        }
    }
}