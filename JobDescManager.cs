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

            JobDesc test = new JobDesc();
            test.mName = "Test Job";
            test.mGUID = "12345";
            test.mSrcFolder = "c:\temp";
            test.mDstFolder = "c__temp";

            mAllJobDesc.Add(test);
        }
    }
}
