using System;
using System.Collections.Generic;
using System.Data;
using DataAccesA;


namespace DomainA
{
    public class DocumentosColaborador
    {


        private int id_colaboradorMultimedia;
        private string nombre;
        private byte[] documento;
        private string extension;
        private int id_tipoMultimedia;
        private int legajoColaborador;


        public int Id_colaboradorMultimedia { get => id_colaboradorMultimedia; set => id_colaboradorMultimedia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }
        public int Id_tipoMultimedia { get => id_tipoMultimedia; set => id_tipoMultimedia = value; }
        public int LegajoColaborador { get => legajoColaborador; set => legajoColaborador = value; }

        public string AgregarDocumento(string nombre, byte[] documento, string extension, int tipoMultimedia, int legajoColaborador, int idEvento)
        {
            ColaboradorDao colaboradorDocumento = new ColaboradorDao();

            string var = colaboradorDocumento.AgregarDocumento(nombre, documento, extension, tipoMultimedia, legajoColaborador, idEvento);
            return var;
        }
        public List<DocumentosColaborador> filtroDocumentosColaborador(int TipoMultimedia, int LegajoColaborador)
        {
            ColaboradorDao colaboradorDocumento = new ColaboradorDao();
            var tabla = colaboradorDocumento.BuscarDocumento(TipoMultimedia, LegajoColaborador);
            var infoDocumento = new List<DocumentosColaborador>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new DocumentosColaborador
                {
                    Id_colaboradorMultimedia = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString(),
                    Id_tipoMultimedia = Convert.ToInt32(item[4]),
                    LegajoColaborador = Convert.ToInt32(item[5])
                });
            }
            return infoDocumento;
        }
        public List<DocumentosColaborador> filtroDocumentosEvento(int idevento)
        {
            ColaboradorDao colaboradorDocumento = new ColaboradorDao();
            var tabla = colaboradorDocumento.BuscarDocumentoEvento(idevento);
            var infoDocumento = new List<DocumentosColaborador>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new DocumentosColaborador
                {
                    Id_colaboradorMultimedia = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString(),
                    Id_tipoMultimedia = Convert.ToInt32(item[4]),
                    LegajoColaborador = Convert.ToInt32(item[5])
                });
            }
            return infoDocumento;
        }
    }

}
