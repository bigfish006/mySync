using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace mySync.Jobs
{
    class Job
    {
        public JobDesc mParentDesc = null;

        private object myLock = new object();
        private bool isStarted = false;
        private bool isDone = false;


        public float    progress        { get { return 0.0f;    } }
        public bool     isActive        { get { return isStarted && !isDone;    } }


        public Job(JobDesc parent)
        {
            mParentDesc = parent;
        }

        public void Start()
        {
            lock(myLock)
            {
                if(isActive)
                {
                    throw new NotSupportedException("Can't start multiple jobs for same job type");
                }

                isStarted = true;
                isDone = false;
                Task.Run(() => { RunJobTree(); });
                Console.WriteLine("Job Started");
            }
        }

        public void RunJobTree()
        {
            // collect source files
            List<string> sourceFiles = CollectSourceFileNames();

            // determine changed files
            List<KeyValuePair<string, int>> newFiles = new List<KeyValuePair<string, int>>();

            Parallel.ForEach(sourceFiles, s =>
                {
                    var newVal = new KeyValuePair<string, int>(s, 7);
                    newFiles.Add(newVal);
                }
            );

            // TODO: producer/consumer models, so that files may be uploaded whilst others are still being hashed

            Thread.Sleep(5000);
            Console.WriteLine("Done: {0}", newFiles.ToString());
            isDone = true;
        }

        private List<string> CollectSourceFileNames()
        {
            List<string> retVal = new List<string>();
            retVal.Add("c:\\file1.txt");
            retVal.Add("c:\\file2.txt");

            return retVal;
        }
    }
}
