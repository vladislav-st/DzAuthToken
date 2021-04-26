using Project_927.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_927.Domain.Interfaces
{
    public interface IJWTTokenService
    {
        string CreateToken(User user);
    }
}
