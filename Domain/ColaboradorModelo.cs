﻿using System;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ColaboradorModelo
    {
        ColaboradorDao colaboradorDao = new ColaboradorDao();

        public string BuscarLegajoUltimoColaborador()
        {
            return colaboradorDao.BuscarLegajoUltimoColaborador();
        }
        public DataTable BuscarColaborador(int legajo,string nombre,string apellido)
        {
            return colaboradorDao.BuscarColaborador(legajo,  nombre,  apellido);
        }
        public string CrearColaborador(string nombre,string apellido, int dni, string cuit, string calle, int numeroCalle,int puesto)
        {
            var creadoExito = colaboradorDao.CrearColaborador(nombre,apellido,dni,cuit,calle,numeroCalle,puesto);
            if(creadoExito == 1)
            {
                return "El colaborador fue creado con exito";
            }
            else
            {
                return "El colaborador no pudo ser creado";
            }

        }
        
        public string EliminarColaborador(int legajo)
        {
            int colaboradorEliminado = colaboradorDao.EliminarColaborador(legajo);
            if(colaboradorEliminado == 1)
            {
                return "Colaborador eliminado correctamente";
            }
            else
            {
                return "No se pudo eliminar al colaborador";
            }
        }

    }
}
