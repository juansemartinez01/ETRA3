using Common.Cache;
using DataAccesA;
using DataAccessA;
using System.Collections.Generic;
using System.Data;

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
        public bool updatePassword(string user, string pass)
        {
            return usuarioDao.updatePassword(user, pass);  
        }
        public DataTable getAllUsuarios(int legajo)
        {
            return usuarioDao.getAllUsuarios(legajo);
        }
        public string crearNuevoUsuario(int idPerfil, string mail, string contraseña, int legajo)
        {
            if(UserCache.perfil != Perfiles.admin) { return "No tiene permisos"; }
            return usuarioDao.crearNuevoUsuario(idPerfil,mail,contraseña,legajo);
        }
        public string modificarUsuario(int idPerfil,int legajo)
        {
            if (UserCache.perfil != Perfiles.admin) { return "No tiene permisos"; }
            return usuarioDao.modificarUsuario(idPerfil, legajo);
        }
    }
}
