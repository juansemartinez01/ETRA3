using System;
using DataAccess;


namespace Domain
{
    public class ColaboradorModelo
    {
        ColaboradorDao colaboradorDao = new ColaboradorDao();

        public string BuscarColaborador(string nombre)
        {
            return colaboradorDao.BuscarColaborador(nombre);
        }

    }
}
