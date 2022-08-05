using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class Backup
    {
        BackupDao backupDao = new BackupDao();
        public string GenerarBackup()
        {
            return backupDao.GenerarBackup();
        }
    }
}
