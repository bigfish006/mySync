using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mySync.Jobs;

namespace mySync
{
    class RestoreFromS3 : IRestoreActions
    {
        public bool Transfer(string inFileName, JobDesc inJobDesc)
        {
            return false;
        }
    }
}
