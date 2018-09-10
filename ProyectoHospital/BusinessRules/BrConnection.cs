using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    using System;
    using System.Web;
    using System.Configuration;
    

    public class brConnection
    {
        public string ConnectionString { get; set; }

        public string ConnectionString2 { get; set; }
        string ArchiveLog { get; set; }
        public brConnection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AZURE"].ConnectionString;
            ArchiveLog = ConfigurationManager.AppSettings["MiPc"];
        }

       /* public void RecordLog(string ErrorMessage, string ErrorDetails)
        {
            beLog obeLog = new beLog();
            obeLog.idUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            obeLog.IpClient = HttpContext.Current.Request.UserHostAddress;
            obeLog.Application = ConfigurationManager.AppSettings["Application"];
            obeLog.dateTime = DateTime.Now;
            obeLog.ErrorMessage = ErrorMessage;
            obeLog.ErrorDetails = ErrorDetails;
            brSaveLog.SaveLog(obeLog, ArchiveLog);
        }*/
    }
}
