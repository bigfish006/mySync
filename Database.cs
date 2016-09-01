using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySync
{
    class Database
    {
        enum FileState
        { 
            Clean,
            Modified,
        };

        FileState GetFileState(string fileName)
        {
            return FileState.Clean;
        }
    }
}
