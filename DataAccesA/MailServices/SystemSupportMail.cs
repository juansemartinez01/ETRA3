using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesA.MailServices
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail(){
            senderMail = "etradistribucionesoftware@hotmail.com";
            password = "7dGUwNjnZL5qyiV";
            host = "smtp-mail.outlook.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
