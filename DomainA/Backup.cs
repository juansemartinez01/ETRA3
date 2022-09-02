using DataAccesA;

namespace DomainA
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
