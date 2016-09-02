using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySync
{
    class JobDescManager
    {
        public List<JobDesc> mAllJobDesc;

        public void Open()
        {
            mAllJobDesc = new List<JobDesc>();

        }
    }
}
