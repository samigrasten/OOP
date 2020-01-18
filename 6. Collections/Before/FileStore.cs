using System;
using System.Collections.Generic;

namespace OOP._6._Collections.Before
{
    internal class FileStore
    {
        public FileStore()
        {
        }

        internal IEnumerable<FileInformation> GetFiles()
        {
            return new List<FileInformation>();
        }
    }
}