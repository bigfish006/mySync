using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySync
{
    class Program
    {
        static JobDescManager mJobMgr;

        static void Main(string[] args)
        {
            // open job desc file
            // for each job, for each file:
            //  determine hash, compare with database
            //  upload if required, update database

            Init();

            while (Run())
            {
            }
        }

        static void Init()
        {
            mJobMgr = new JobDescManager();
        }

        static bool Run()
        {
            return false;
        }
    }
}
