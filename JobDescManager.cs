using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySync
{
    class JobDescManager
    {
        public List<JobDesc> mAllJobDesc = null;

        public void Open()
        {
            mAllJobDesc = new List<JobDesc>();

            PushTestJobs();
            ReadJobs();
        }

        private void PushTestJobs()
        {
            {
                JobDesc test = new JobDesc();
                test.mName = "Test Job1";
                test.mGUID = Guid.NewGuid();
                test.mSrcFolder = "c:\temp";
                test.mDstFolder = "c__temp";
                mAllJobDesc.Add(test);
            }

            {
                JobDesc test2 = new JobDesc();
                test2.mName = "Test Job2";
                test2.mGUID = Guid.NewGuid();
                test2.mSrcFolder = "c:\temp2";
                test2.mDstFolder = "c__temp2";
                mAllJobDesc.Add(test2);
            }
        }

        private void ReadJobs()
        {
        }
    }
}
