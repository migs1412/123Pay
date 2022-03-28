using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        string IpAddress { get; }
    }
}
