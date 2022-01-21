using System;
using System.Security.Claims;
using System.Security.Principal;
namespace Custom.Extensions
{

    public static class ClaimsPrincipalExtension
    {
             public static string GetName(this IPrincipal usr)
        {
            var name = ((ClaimsIdentity)usr.Identity).FindFirst("Name"); //first name
            if (name != null)
                return name.Value;
            return "";
        }

        public static string GetLastName(this IPrincipal usr)
        {
            var lastname = ((ClaimsIdentity)usr.Identity).FindFirst("LastName");
            if (lastname != null)
                return lastname.Value;

            return "";
        }

        public static string GetFullName(this IPrincipal usr)
        {
            var fullNameClaim = ((ClaimsIdentity)usr.Identity).FindFirst("FullName");
            if (fullNameClaim != null)
                return fullNameClaim.Value;

            return "";
        }
    }
}