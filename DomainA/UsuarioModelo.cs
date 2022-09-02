using DataAccesA;

namespace DomainA
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
