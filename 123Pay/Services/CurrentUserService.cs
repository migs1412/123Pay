using _123Pay.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _123Pay.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            IpAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
        }

        public string UserId { get; }

        public string IpAddress { get; }
    }
}
