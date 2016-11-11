using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mySync.Jobs;

namespace mySync
{
    class BackupToS3 : IBackupActions
    {
        bool IBackupActions.Transfer(string inFileName, JobDesc inJobDesc)
        {
            return false;
        }
    }
}
