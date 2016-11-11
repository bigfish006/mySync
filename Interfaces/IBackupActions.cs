using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mySync.Jobs;

namespace mySync
{
    interface IBackupActions
    {
        bool Transfer(string inFileName, JobDesc inJobDesc);
    }
}
