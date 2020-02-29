using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class BackupBLL
    {
        BackupDAL backupDAL = new BackupDAL();

        public void GerarBackup()
        {
            backupDAL.GerarBackup();
        }
    }
}
