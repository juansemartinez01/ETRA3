using Common.Cache;
using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;

namespace DomainA
{
    public class ReporteSalXCargo
    {
        public DateTime reportDate { get; private set; }
        public List<SalXCargoListing> salXCargoListing { get; private set; }

        public void createReporteSalXCargo()
        {
            if (UserCache.perfil == Perfiles.admin)
            {
                reportDate = DateTime.Now;
                var report = new ReporteSalXCargoDao();
                DataTable resultado = report.getSalXCargo();
                salXCargoListing = new List<SalXCargoListing>();
                foreach (DataRow row in resultado.Rows)
                {
                    var salXCargoModel = new SalXCargoListing()
                    {
                        cargo = Convert.ToString(row[0]),
                        monto = Convert.ToDouble(row[1])
                    };

                    salXCargoListing.Add(salXCargoModel);
                }
            }
        }

    }
}
