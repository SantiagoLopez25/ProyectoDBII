using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Login
{
    public interface ILoginService
    {
        DataTable InicioDeSesion(string user, string password);
    }
}
