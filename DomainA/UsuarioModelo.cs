using DataAccesA;
using System.Collections.Generic;

namespace DomainA
{
    public class UsuarioModelo
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        public bool LoginUser(string user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }
        public List<string> recoverPassword(string userRequesting)
        {
            return usuarioDao.recoverPassword(userRequesting);
        }
        public string updatePassword(string user, string pass)
        {
            return usuarioDao.updatePassword(user, pass);  
        }
    }
}
