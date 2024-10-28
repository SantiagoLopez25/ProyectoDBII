using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Login
{
    internal interface IRepositoryLogin
    {
        string InicioDeSesion(string user, string password);
    }
}
