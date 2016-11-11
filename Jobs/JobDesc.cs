using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySync.Jobs
{
    class JobDesc
    {
        public string   mName = null;
        public Guid     mGUID;
        public string   mSrcFolder = null;
        public string   mDstFolder = null;

        public Job StartJob()
        {
            Job newJob = new Job(this);

            newJob.Start();

            return newJob;
        }
    }
}
