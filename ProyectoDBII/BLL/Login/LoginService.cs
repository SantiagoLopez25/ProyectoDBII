﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Login;

namespace BLL.Login
{
    public class LoginService : ILoginService
    {
        private readonly RepositoryLogin repositoryLogin = new RepositoryLogin();
        public string inicioSesion(string user, string password)
        {
            
              
            return repositoryLogin.InicioDeSesion(user, password);
        }

        public DataTable InicioDeSesion(string user, string password)
        {
            return repositoryLogin.InicioSesion(user, password);
        }
    }
}
