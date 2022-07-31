using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class UsuarioModelo
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        public bool LoginUser(string user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }
    }
}
