using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mySync.Jobs;

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
            Run();
        }

        static void Init()
        {
            mJobMgr = new JobDescManager();
            mJobMgr.Open();
        }

        static void Run()
        {
            do
            {
                ClearUI();
                ShowJobsAvailable();
                WaitForInput();
            }
            while (true);
        }

        private static void ClearUI()
        {
            Console.Clear();
        }

        private static void ShowJobsAvailable()
        {
            int idx = 0;
            foreach (var job in mJobMgr.mAllJobDesc)
            {
                Console.WriteLine("Job {0}: {1}", idx++, job.mName);
            }
        }

        private static void WaitForInput()
        {
            Console.WriteLine("Select a job...");

            while (!Console.KeyAvailable)
            {
                Thread.Sleep(250);
            }

            ConsoleKeyInfo cki = Console.ReadKey(true);

            int indexPressed = cki.KeyChar - '0';
            try
            {
                Console.WriteLine("Selected {0}", mJobMgr.mAllJobDesc[indexPressed].mName);

                mJobMgr.StartJob(mJobMgr.mAllJobDesc[indexPressed].mGUID);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to find index: {0}\nMessage: {1}\nPress any key to continue", cki.KeyChar, ex.Message);
                Console.ReadKey();
            }

            Thread.Sleep(1000);
        }

    }
}
