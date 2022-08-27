using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public class ReporteSalXCargo
    {
        public DateTime reportDate { get; private set; }
        public List<SalXCargoListing> salXCargoListing { get; private set; }

        public void createReporteSalXCargo()
        {
            reportDate = DateTime.Now;
            var report = new ReporteSalXCargoDao();
            DataTable resultado = report.getSalXCargo();
            salXCargoListing = new List<SalXCargoListing>();
            foreach (System.Data.DataRow row in resultado.Rows)
            {
                var salXCargoModel = new SalXCargoListing()
                {
                    monto = Convert.ToDouble(row[0]),
                    cargo = Convert.ToString(row[0])

                };
                
                salXCargoListing.Add(salXCargoModel);
            }
            

        }

    }
}
