using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;


namespace DomainA
{
    public class ReporteTardanza
    {
        public DateTime reportDate { get; private set; }

        public DateTime fechaInicio{ get; private set; }
        public DateTime fechaFin { get; private set; }
        public List<TardanzaListing> tardanzaListing { get; private set; }

        public void createReportTardanza(DateTime startDate, DateTime endDate)
        {
            reportDate = DateTime.Now;
            fechaInicio = startDate;
            fechaFin = endDate;
            tardanzaListing = new List<TardanzaListing>();
            var report = new ReporteTardanzaDao();
            DataTable resultado = report.getTardanzas(fechaInicio,fechaFin);
            foreach (DataRow row in resultado.Rows)
            {
                var tardanzaModel = new TardanzaListing()
                {
                    LegajoColaborador = Convert.ToInt32(row[0]),
                    Cargo = Convert.ToString(row[1]),
                    Descripcion = Convert.ToString(row[2]),
                    fecha = Convert.ToDateTime(row[3]),
                };

                tardanzaListing.Add(tardanzaModel);
            }
        }
    }
}
